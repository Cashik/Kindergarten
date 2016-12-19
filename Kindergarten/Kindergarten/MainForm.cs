using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarten
{
    public partial class MainForm : Form
    {
        bool authorization = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void детиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KidsForm kf = new KidsForm(authorization);
            kf.ShowDialog();

        }

        private void родителиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ParentsForm kf = new ParentsForm(authorization);
            kf.ShowDialog();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupsForm gf = new GroupsForm(authorization);
            gf.ShowDialog();
        }

        private void emplToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm ef = new EmployeeForm(authorization);
            ef.ShowDialog();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostsForm pf = new PostsForm(authorization);
            pf.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (authorization)
            {
                authorization = false;
                userNameLbl.Text = "Гость.";
            }else
            {
                LoginForm lf = new LoginForm();
                if (lf.ShowDialog() == DialogResult.OK)
                {
                    authorization = true;
                    userNameLbl.Text = "Авторизированный пользователь.";
                }
            }
            
        }
    }
}
