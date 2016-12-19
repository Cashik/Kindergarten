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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm(bool auth)
        {
            InitializeComponent();
            if (!auth)
            {
                Employee_dgv.ReadOnly = true;
                saveChildren.Visible = false;
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDBDataSet.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.kindergartenDBDataSet.Post);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.kindergartenDBDataSet.Employee);

        }

        private void saveChildren_Click(object sender, EventArgs e)
        {
            Employee_dgv.EndEdit();
            employeeBindingSource.EndEdit();

            DataSet changes = this.kindergartenDBDataSet.GetChanges();
            if (changes != null)
            {
                int updatedRows = employeeTableAdapter.Adapter.Update(changes);
                employeeTableAdapter.Fill(kindergartenDBDataSet.Employee);
            }
        }

        private void Employee_dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void Employee_dgv_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow ThisDataRow = ((DataGridView)sender).CurrentRow;
            ThisDataRow.Cells["id_empl_dgv"].Value = Guid.NewGuid();
        }
    }
}
