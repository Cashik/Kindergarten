using Kindergarten.KindergartenDBDataSetTableAdapters;
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
    public partial class KidsForm : Form
    {
        public KidsForm(bool auth=false)
        {
            InitializeComponent();
            if (!auth)
            {
                children_dsv.ReadOnly = true;
                saveChildren.Visible = false;
            }
        }

        ~KidsForm()
        {

        }
        private void KidsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDBDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.kindergartenDBDataSet.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDBDataSet.Child". При необходимости она может быть перемещена или удалена.
            this.childTableAdapter.Fill(this.kindergartenDBDataSet.Child);

        }

        private void children_dsv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            /**/
        }

        private void children_dsv_RowsAdded(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void children_dsv_RowsAdded2(object sender, DataGridViewCellEventArgs e)
        {
           // childTableAdapter.Update(kindergartenDBDataSet);
        }
        private void children_dsv_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
        }
        private void children_dsv_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow ThisDataRow = ((DataGridView)sender).CurrentRow;
            ThisDataRow.Cells["id"].Value = Guid.NewGuid();
        }

        private void children_dsv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void children_dsv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void children_dsv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void saveChildren_Click(object sender, EventArgs e)
        {
            children_dsv.EndEdit();
            childBindingSource.EndEdit();
            
            DataSet changes = this.kindergartenDBDataSet.GetChanges();
            if (changes != null)
            {
                int updatedRows = childTableAdapter.Adapter.Update(changes);
                childTableAdapter.Fill(kindergartenDBDataSet.Child);
            }
        }
    }
}
