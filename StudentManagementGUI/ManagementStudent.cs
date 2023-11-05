using BusinessObject;
using ManagementService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementGUI
{
    public partial class ManagementStudent : Form
    {
        User _user;
        private IStudentService _studentService;
        private IClassService _classService;
        public List<StudentProfile> _students;
        public List<Class> _classes;
        private const string fileStudent = @"../../../Students.json";
        private const string fileClass = @"../../../Classes.json";
        public ManagementStudent(User user)
        {
            InitializeComponent();
            _user = user;
            _studentService = new StudentService();
            _classService = new ClassService();
            _students = _studentService.GetAll(fileStudent, "");
            _classes = _classService.GetAll(fileClass);
        }

        public void LoadComboBox()
        {
            cbClass.DataSource = _classes;
            cbClass.DisplayMember = "ClassName";
            cbClass.ValueMember = "ClassID";
        }

        private void Reset()
        {
            txtFullName.Text = string.Empty;
            rdMale.Checked = true;
            richAdress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbClass.SelectedIndex = 0;
        }
        private void ManagementStudent_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudent.DataSource = _students.Select(x =>
            {
                var classObject = _classes.SingleOrDefault(p => p.ClassID.Equals(x.ClassID));
                return new
                {
                    x.StudentID,
                    x.FullName,
                    BirthDay = x.DateOfBirth.ToString("MM-dd-yyyy"),
                    x.Gender,
                    x.Address,
                    x.Email,
                    x.ClassID,
                    ClassName = classObject != null ? classObject.ClassName : null,
                };
            }).ToList();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFullName.Text = dgvStudent.CurrentRow.Cells["FullName"].Value.ToString();
            string gender = dgvStudent.CurrentRow.Cells["Gender"].Value.ToString();
            if (gender == "male") rdMale.Checked = true;
            else rdFemale.Checked = true;
            string birthDay = dgvStudent.CurrentRow.Cells["BirthDay"].Value.ToString();
            DateTime parsedDate;
            if (DateTime.TryParseExact(birthDay, "MM-dd-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                dtpBirthday.Value = parsedDate;
            }
            else MessageBox.Show("Cant parse string to DateTime", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            richAdress.Text = dgvStudent.CurrentRow.Cells["Address"].Value.ToString();
            txtEmail.Text = dgvStudent.CurrentRow.Cells["Email"].Value.ToString();
            string classID = dgvStudent.CurrentRow.Cells["ClassID"].Value.ToString();
            cbClass.SelectedIndex = _classes.IndexOf(_classes.SingleOrDefault(p => p.ClassID.Equals(classID)));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            _students = _studentService.GetAll(fileStudent, search);
            ManagementStudent_Load(this, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_user.Role == 1)
            {
                AddStudent addForm = new AddStudent(this);
                addForm.DataAdded += (s, data) =>
                {
                    try
                    {
                        _studentService.AddStudent(data, fileStudent);
                        MessageBox.Show("Add successfully", "Notification", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Add failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    _students = _studentService.GetAll(fileStudent, "");
                    ManagementStudent_Load(this, e);
                };
                addForm.ShowDialog();
            }
            else MessageBox.Show("You aren't permision", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_user.Role == 1)
            {
                int id = int.Parse(dgvStudent.CurrentRow.Cells["StudentID"].Value.ToString());
                StudentProfile student = _studentService.GetStudentByID(id, fileStudent);
                if (student != null)
                {
                    string resultFullName = ValidationHelper.ValidateFullName(txtFullName.Text.Trim());
                    if (resultFullName != null)
                    {
                        MessageBox.Show(resultFullName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    student.FullName = txtFullName.Text.Trim();
                    if (rdMale.Checked) student.Gender = "male";
                    if (rdFemale.Checked) student.Gender = "female";
                    if (string.IsNullOrWhiteSpace(richAdress.Text))
                    {
                        MessageBox.Show("Address cannot blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    student.Address = richAdress.Text.Trim();
                    student.DateOfBirth = dtpBirthday.Value;
                    string resultEmail = ValidationHelper.ValidateEmail(txtEmail.Text.Trim());
                    if (resultEmail != null)
                    {
                        MessageBox.Show(resultEmail, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    student.Email = txtEmail.Text.Trim();
                    student.ClassID = cbClass.SelectedValue.ToString();
                    DialogResult result = MessageBox.Show("Are you sure to update", "Notification", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (_studentService.UpdateStudent(student, fileStudent))
                        {
                            _students = _studentService.GetAll(fileStudent, "");
                            ManagementStudent_Load(this, e);
                            MessageBox.Show("Update successfully!", "Notification", MessageBoxButtons.OK);
                            Reset();
                        }
                        else MessageBox.Show("Update failed: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else return;
                }

            }
            else MessageBox.Show("You aren't permision", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (_user.Role == 1)
            {
                int id = int.Parse(dgvStudent.CurrentRow.Cells["StudentID"].Value.ToString());
                DialogResult result = MessageBox.Show("Are you sure to delete", "Notification", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (_studentService.DeleteStudent(id, fileStudent))
                    {
                        _students = _studentService.GetAll(fileStudent, "");
                        ManagementStudent_Load(this, e);
                        MessageBox.Show("Delete successfully!", "Notification", MessageBoxButtons.OK);
                        Reset();
                    }
                    else MessageBox.Show("Delete failed: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else return;
            }
            else MessageBox.Show("You aren't permision", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
