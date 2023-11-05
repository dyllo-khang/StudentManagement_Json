using BusinessObject;
using ManagementService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementGUI
{
    public partial class LoginForm : Form
    {
        private IUserService _userService;
        private const string fileUser = @"../../../Users.json";
        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = _userService.GetUserByEmail(txtEmail.Text, txtPassword.Text, fileUser);
            if (user != null)
            {
                ManagementStudent management = new ManagementStudent(user);
                this.Hide();
                management.Show();
            }
            else MessageBox.Show("Login false, email or password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
        }
    }
}

