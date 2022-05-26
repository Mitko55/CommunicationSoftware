using Discord_2._0.Controller;
using Discord_2._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_2._0.View
{
    public partial class SignUpPage : Form
    {
        RegisterController rg = new RegisterController();
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            if (txtName.Text == String.Empty)
            {
                MessageBox.Show("Please fill the username!");
            }
            else if (txtPassSignUp.Text == String.Empty)
            {
                MessageBox.Show("Please fill the password");
            }
            else if (txtEmailSignUp.Text == String.Empty)
            {
                MessageBox.Show("Please fill the email");
            }
            else
            {
                user.Name = txtName.Text;
                user.Password = txtPassSignUp.Text;
                user.Email = txtEmailSignUp.Text;
                rg.AddUser(user);
                MessageBox.Show("User is registered");
                LoginPage loginPage = new LoginPage();
                this.Hide();
                loginPage.Show();
            }
        }
    }
}
