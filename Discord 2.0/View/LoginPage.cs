using Discord_2._0.Controller;
using Discord_2._0.Model;
using Discord_2._0.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_2._0
{
    public partial class LoginPage : Form
    {
        private RegisterController rb = new RegisterController();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpPage signUp = new SignUpPage();
            signUp.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Login = rb.Login(txtEmail.Text, txtPass.Text);
            if (Login != null)
            {
                MessageBox.Show(Login);
            }
            else
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
        }
    }
}
