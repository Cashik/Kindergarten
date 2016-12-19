namespace Kindergarten
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Employee_dgv = new System.Windows.Forms.DataGridView();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergartenDBDataSet = new Kindergarten.KindergartenDBDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.saveChildren = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new Kindergarten.KindergartenDBDataSetTableAdapters.EmployeeTableAdapter();
            this.postTableAdapter = new Kindergarten.KindergartenDBDataSetTableAdapters.PostTableAdapter();
            this.id_empl_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Employee_dgv
            // 
            this.Employee_dgv.AutoGenerateColumns = false;
            this.Employee_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_empl_dgv,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.postidDataGridViewTextBoxColumn,
            this.post_name});
            this.Employee_dgv.DataSource = this.employeeBindingSource;
            this.Employee_dgv.Location = new System.Drawing.Point(16, 36);
            this.Employee_dgv.Name = "Employee_dgv";
            this.Employee_dgv.Size = new System.Drawing.Size(789, 366);
            this.Employee_dgv.TabIndex = 0;
            this.Employee_dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Employee_dgv_RowsAdded);
            this.Employee_dgv.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Employee_dgv_UserAddedRow);
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.kindergartenDBDataSet;
            // 
            // kindergartenDBDataSet
            // 
            this.kindergartenDBDataSet.DataSetName = "KindergartenDBDataSet";
            this.kindergartenDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.kindergartenDBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сотрудники";
            // 
            // saveChildren
            // 
            this.saveChildren.Location = new System.Drawing.Point(651, 7);
            this.saveChildren.Name = "saveChildren";
            this.saveChildren.Size = new System.Drawing.Size(154, 23);
            this.saveChildren.TabIndex = 8;
            this.saveChildren.Text = "Сохранить изменения";
            this.saveChildren.UseVisualStyleBackColor = true;
            this.saveChildren.Click += new System.EventHandler(this.saveChildren_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // id_empl_dgv
            // 
            this.id_empl_dgv.DataPropertyName = "id";
            this.id_empl_dgv.HeaderText = "id";
            this.id_empl_dgv.Name = "id_empl_dgv";
            this.id_empl_dgv.Visible = false;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 149;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 149;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 199;
            // 
            // postidDataGridViewTextBoxColumn
            // 
            this.postidDataGridViewTextBoxColumn.DataPropertyName = "post_id";
            this.postidDataGridViewTextBoxColumn.HeaderText = "post_id";
            this.postidDataGridViewTextBoxColumn.Name = "postidDataGridViewTextBoxColumn";
            this.postidDataGridViewTextBoxColumn.Visible = false;
            // 
            // post_name
            // 
            this.post_name.DataPropertyName = "post_id";
            this.post_name.DataSource = this.postBindingSource;
            this.post_name.DisplayMember = "name";
            this.post_name.HeaderText = "Должность";
            this.post_name.Name = "post_name";
            this.post_name.ValueMember = "id";
            this.post_name.Width = 149;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 414);
            this.Controls.Add(this.saveChildren);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employee_dgv);
            this.Name = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Employee_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveChildren;
        private KindergartenDBDataSet kindergartenDBDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private KindergartenDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource postBindingSource;
        private KindergartenDBDataSetTableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empl_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn post_name;
    }
}