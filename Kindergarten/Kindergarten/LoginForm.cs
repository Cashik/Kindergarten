using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kindergarten.KindergartenDBDataSetTableAdapters;

namespace Kindergarten
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string login = loginTxt.Text;
            string password = passwordTxt.Text;
             
            if ((int)userTableAdapter1.LoginPwdExistQuery(login, password)>0)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин/пароль");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.userTableAdapter1.Fill(this.kindergartenDBDataSet1.User);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void info_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.ShowDialog();
        }
    }
}
