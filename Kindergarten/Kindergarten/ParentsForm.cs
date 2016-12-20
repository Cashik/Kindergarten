using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Kindergarten.KindergartenDBDataSet;

namespace Kindergarten
{
    public partial class ParentsForm : Form
    {
        public ParentsForm(bool auth)
        {
            InitializeComponent();
            if (!auth)
            {
                Parents_dgv.ReadOnly = true;
                MakeParentBtn.Visible = false;
                saveChildren.Visible = false;
            }
        }

        private void ParentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDBDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.kindergartenDBDataSet.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDBDataSet.Child". При необходимости она может быть перемещена или удалена.
            this.childTableAdapter.Fill(this.kindergartenDBDataSet.Child);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDBDataSet.Child_of_parent". При необходимости она может быть перемещена или удалена.
            this.child_of_parentTableAdapter.Fill(this.kindergartenDBDataSet.Child_of_parent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDBDataSet.Parent". При необходимости она может быть перемещена или удалена.
            this.parentTableAdapter.Fill(this.kindergartenDBDataSet.Parent);
            ChildOfParentRB.Select();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Parents_dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Parents_dgv_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Parents_dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            UpdateChildDGV();
        }

        private void Parents_dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewRow ThisDataRow = ((DataGridView)sender).CurrentRow;
            if (ThisDataRow != null && ThisDataRow.IsNewRow)
                ThisDataRow.Cells["id"].Value = Guid.NewGuid();
        }

        private void saveChildren_Click(object sender, EventArgs e)
        {
            childrenOfParent_dsv.EndEdit();
            parentBindingSource.EndEdit();

            DataSet changes = this.kindergartenDBDataSet.GetChanges();
            if (changes != null)
            {
                //Data has changes. 
                //use update method in the adapter. it should update your datasource
                int updatedRows = parentTableAdapter.Adapter.Update(changes);
                parentTableAdapter.Fill(kindergartenDBDataSet.Parent);
            }
        }



        // метод обновения детей
        private void UpdateChildDGV()
        {
            if (Parents_dgv.CurrentRow != null
                && Parents_dgv.CurrentRow.Index < (Parents_dgv.RowCount - 1)
                && Parents_dgv.Rows[Parents_dgv.CurrentRow.Index].Cells["id"].Value != null
                && Parents_dgv.Rows[Parents_dgv.CurrentRow.Index].Cells["id"].Value.ToString() != "")
            {
                if (ChildOfParentRB.Checked)
                {
                    child_of_parent2TableAdapter.Fill((KindergartenDBDataSet.Child_of_parent2DataTable)kindergartenDBDataSet.Tables["Child_of_parent2"],
                        (Guid)Parents_dgv.Rows[Parents_dgv.CurrentRow.Index].Cells["id"].Value);
                }
                else
                {
                    child_of_parent2TableAdapter.FillBy((KindergartenDBDataSet.Child_of_parent2DataTable)kindergartenDBDataSet.Tables["Child_of_parent2"],
                        (Guid)Parents_dgv.Rows[Parents_dgv.CurrentRow.Index].Cells["id"].Value);
                }

            }
        }

        private void ChildOfParentRB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChildDGV();
        }

        private void NotChildOfParentRB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChildDGV();
        }
        private void Parents_dgv_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //if ( Parents_dgv.CurrentRow.Index < (Parents_dgv.RowCount - 1))
            UpdateChildDGV();
        }

        private void MakeParentBtn_Click(object sender, EventArgs e)
        {
            if (NotChildOfParentRB.Checked)
            {
                try
                {
                    child_of_parent2TableAdapter.InsertQuery((Guid)Parents_dgv.CurrentRow.Cells["id"].Value,
                        (Guid)childrenOfParent_dsv.CurrentRow.Cells["id_cop2"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ("Ошибка связывания! "));
                }
            }
            else
            {
                try
                {
                    child_of_parent2TableAdapter.DeleteQuery((Guid)Parents_dgv.CurrentRow.Cells["id"].Value,
                        (Guid)childrenOfParent_dsv.CurrentRow.Cells["id_cop2"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ("Ошибка отвязки! "));
                }
            }
            UpdateChildDGV();
        }
        
        private void Parents_dgv_UserRowsAdded(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow ThisDataRow = ((DataGridView)sender).CurrentRow;
                ThisDataRow.Cells["id"].Value = Guid.NewGuid();
        }

        private void Parents_dgv_Enter(object sender, EventArgs e)
        {
            UpdateChildDGV();
        }

        private void Parents_dgv_CurrentCellChanged(object sender, EventArgs e)
        {
            UpdateChildDGV();
        }
    }
}
