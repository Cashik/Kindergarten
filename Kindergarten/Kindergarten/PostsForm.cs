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
    public partial class PostsForm : Form
    {
        public PostsForm(bool auth)
        {
            InitializeComponent();
            if (!auth)
            {
                posts_dgv.ReadOnly = true;
                SavePostsBtn.Visible = false;
            }
        }

        private void PostsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDBDataSet.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.kindergartenDBDataSet.Post);

        }

        private void groups_dgv_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow ThisDataRow = ((DataGridView)sender).CurrentRow;
            ThisDataRow.Cells[0].Value = Guid.NewGuid();
        }

        private void SavePostsBtn_Click(object sender, EventArgs e)
        {
            posts_dgv.EndEdit();
            postBindingSource.EndEdit();

            DataSet changes = this.kindergartenDBDataSet.GetChanges();
            if (changes != null)
            {
                int updatedRows = postTableAdapter.Adapter.Update(changes);
                postTableAdapter.Fill(kindergartenDBDataSet.Post);
            }
        }
    }
}
