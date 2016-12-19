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
    public partial class GroupsForm : Form
    {
        public GroupsForm(bool auth)
        {
            InitializeComponent();
            if (!auth)
            {
                groups_dgv.ReadOnly = true;
                SaveGroupsBtn.Visible = false;
            }
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDBDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.kindergartenDBDataSet.Group);

        }

        private void SaveGroupsBtn_Click(object sender, EventArgs e)
        {
            groups_dgv.EndEdit();
            groupBindingSource.EndEdit();

            DataSet changes = this.kindergartenDBDataSet.GetChanges();
            if (changes != null)
            {
                int updatedRows = groupTableAdapter.Adapter.Update(changes);
                groupTableAdapter.Fill(kindergartenDBDataSet.Group);
            }
        }

        private void groups_dgv_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow ThisDataRow = ((DataGridView)sender).CurrentRow;
            ThisDataRow.Cells["id_group_dgv"].Value = Guid.NewGuid();
        }

        private void groups_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
