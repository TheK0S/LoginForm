using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.NameField.AutoSize = false;
            this.NameField.Size = new Size(this.NameField.Width, 35);

            this.EmailField.AutoSize = false;
            this.EmailField.Size = new Size(this.NameField.Width, 35);

            this.PasswordField.AutoSize = false;       
            this.PasswordField.Size = new Size(this.NameField.Width, 35);
        }        

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void EmailField_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcceptConditions_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkConditions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FooterLabel_Click(object sender, EventArgs e)
        {

        }
    }
}


