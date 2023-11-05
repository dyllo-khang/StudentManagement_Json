using BusinessObject;
using ManagementService;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementGUI
{
    public partial class RegisterForm : Form
    {
        private IUserService _userService;
        public RegisterForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User lastUser = _userService.GetAll(@"../../../Users.json").Last();
            User newUser = new User();
            newUser.Id = lastUser.Id + 1;
            string resultFullName = ValidationHelper.ValidateFullName(txtFullName.Text.Trim());
            if (resultFullName != null)
            {
                MessageBox.Show(resultFullName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            newUser.FullName = txtFullName.Text.Trim();
            string resultEmail = ValidationHelper.ValidateEmail(txtEmail.Text.Trim());
            if (resultEmail != null)
            {
                MessageBox.Show(resultEmail, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            newUser.Email = txtEmail.Text.Trim();
            string resultPassword = ValidationHelper.ValidatePassword(txtPassword.Text.Trim());
            if (resultPassword != null)
            {
                MessageBox.Show(resultPassword, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string passWord = txtPassword.Text.Trim();
            newUser.PassWord = passWord;
            newUser.Role = 2;
            if (!txtConfirm.Text.Trim().Equals(passWord))
            {
                MessageBox.Show("Confirm password different password", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //User newUser = new User(id, fullName, email, passWord, role);
            bool add = _userService.AddUser(newUser, @"../../../Users.json");
            if (add)
            {
                MessageBox.Show("Sign up successfully", "Notification", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Sign up failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
