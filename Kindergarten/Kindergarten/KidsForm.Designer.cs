namespace Kindergarten
{
    partial class KidsForm
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
            this.children_dsv = new System.Windows.Forms.DataGridView();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergartenDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergartenDBDataSet = new Kindergarten.KindergartenDBDataSet();
            this.childBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childTableAdapter = new Kindergarten.KindergartenDBDataSetTableAdapters.ChildTableAdapter();
            this.groupTableAdapter = new Kindergarten.KindergartenDBDataSetTableAdapters.GroupTableAdapter();
            this.childfk0BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childfk0BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.saveChildren = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_cb = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.children_dsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childfk0BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childfk0BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // children_dsv
            // 
            this.children_dsv.AutoGenerateColumns = false;
            this.children_dsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.children_dsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.groupidDataGridViewTextBoxColumn,
            this.group_cb});
            this.children_dsv.DataSource = this.childBindingSource;
            this.children_dsv.Location = new System.Drawing.Point(11, 36);
            this.children_dsv.Name = "children_dsv";
            this.children_dsv.Size = new System.Drawing.Size(500, 239);
            this.children_dsv.TabIndex = 0;
            this.children_dsv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.children_dsv_CellEndEdit);
            this.children_dsv.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.children_dsv_NewRowNeeded);
            this.children_dsv.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.children_dsv_RowsAdded);
            this.children_dsv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.children_dsv_RowsAdded);
            this.children_dsv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.children_dsv_RowsRemoved);
            this.children_dsv.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.children_dsv_UserAddedRow);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.kindergartenDBDataSetBindingSource;
            // 
            // kindergartenDBDataSetBindingSource
            // 
            this.kindergartenDBDataSetBindingSource.DataSource = this.kindergartenDBDataSet;
            this.kindergartenDBDataSetBindingSource.Position = 0;
            // 
            // kindergartenDBDataSet
            // 
            this.kindergartenDBDataSet.DataSetName = "KindergartenDBDataSet";
            this.kindergartenDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // childBindingSource
            // 
            this.childBindingSource.DataMember = "Child";
            this.childBindingSource.DataSource = this.kindergartenDBDataSetBindingSource;
            // 
            // childTableAdapter
            // 
            this.childTableAdapter.ClearBeforeFill = true;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // childfk0BindingSource
            // 
            this.childfk0BindingSource.DataMember = "Child_fk0";
            this.childfk0BindingSource.DataSource = this.groupBindingSource;
            // 
            // childfk0BindingSource1
            // 
            this.childfk0BindingSource1.DataMember = "Child_fk0";
            this.childfk0BindingSource1.DataSource = this.groupBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дети";
            // 
            // saveChildren
            // 
            this.saveChildren.Location = new System.Drawing.Point(356, 9);
            this.saveChildren.Name = "saveChildren";
            this.saveChildren.Size = new System.Drawing.Size(154, 23);
            this.saveChildren.TabIndex = 6;
            this.saveChildren.Text = "Сохранить изменения";
            this.saveChildren.UseVisualStyleBackColor = true;
            this.saveChildren.Click += new System.EventHandler(this.saveChildren_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // groupidDataGridViewTextBoxColumn
            // 
            this.groupidDataGridViewTextBoxColumn.DataPropertyName = "group_id";
            this.groupidDataGridViewTextBoxColumn.HeaderText = "group_id";
            this.groupidDataGridViewTextBoxColumn.Name = "groupidDataGridViewTextBoxColumn";
            this.groupidDataGridViewTextBoxColumn.Visible = false;
            // 
            // group_cb
            // 
            this.group_cb.DataPropertyName = "group_id";
            this.group_cb.DataSource = this.groupBindingSource;
            this.group_cb.DisplayMember = "name";
            this.group_cb.HeaderText = "Группа";
            this.group_cb.Name = "group_cb";
            this.group_cb.ValueMember = "id";
            // 
            // KidsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 287);
            this.Controls.Add(this.saveChildren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.children_dsv);
            this.Name = "KidsForm";
            this.Load += new System.EventHandler(this.KidsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.children_dsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childfk0BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childfk0BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView children_dsv;
        private System.Windows.Forms.BindingSource kindergartenDBDataSetBindingSource;
        private KindergartenDBDataSet kindergartenDBDataSet;
        private System.Windows.Forms.BindingSource childBindingSource;
        private KindergartenDBDataSetTableAdapters.ChildTableAdapter childTableAdapter;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private KindergartenDBDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.BindingSource childfk0BindingSource1;
        private System.Windows.Forms.BindingSource childfk0BindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveChildren;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn group_cb;
    }
}