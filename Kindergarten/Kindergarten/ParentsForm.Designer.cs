namespace Kindergarten
{
    partial class ParentsForm
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
            this.Parents_dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergartenDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergartenDBDataSet = new Kindergarten.KindergartenDBDataSet();
            this.parentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.childofparentfk0BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childofparentfk0BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.childBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.childrenOfParent_dsv = new System.Windows.Forms.DataGridView();
            this.id_cop2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childofparent2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.childofparentfk0BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.childofparentfk1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childofparent2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.saveChildren = new System.Windows.Forms.Button();
            this.ChildOfParentRB = new System.Windows.Forms.RadioButton();
            this.NotChildOfParentRB = new System.Windows.Forms.RadioButton();
            this.MakeParentBtn = new System.Windows.Forms.Button();
            this.parentTableAdapter = new Kindergarten.KindergartenDBDataSetTableAdapters.ParentTableAdapter();
            this.child_of_parentTableAdapter = new Kindergarten.KindergartenDBDataSetTableAdapters.Child_of_parentTableAdapter();
            this.childTableAdapter = new Kindergarten.KindergartenDBDataSetTableAdapters.ChildTableAdapter();
            this.groupTableAdapter = new Kindergarten.KindergartenDBDataSetTableAdapters.GroupTableAdapter();
            this.child_of_parent2TableAdapter = new Kindergarten.KindergartenDBDataSetTableAdapters.Child_of_parent2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Parents_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childofparentfk0BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childofparentfk0BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfParent_dsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childofparent2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childofparentfk0BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childofparentfk1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childofparent2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // Parents_dgv
            // 
            this.Parents_dgv.AutoGenerateColumns = false;
            this.Parents_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Parents_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.surname,
            this.name,
            this.phone,
            this.address});
            this.Parents_dgv.DataSource = this.parentBindingSource;
            this.Parents_dgv.Location = new System.Drawing.Point(12, 36);
            this.Parents_dgv.Name = "Parents_dgv";
            this.Parents_dgv.Size = new System.Drawing.Size(662, 226);
            this.Parents_dgv.TabIndex = 0;
            this.Parents_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Parents_dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Parents_dgv_CellValueChanged);
            this.Parents_dgv.CurrentCellChanged += new System.EventHandler(this.Parents_dgv_CurrentCellChanged);
            this.Parents_dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Parents_dgv_RowEnter);
            this.Parents_dgv.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.Parents_dgv_RowLeave);
            this.Parents_dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Parents_dgv_RowsAdded);
            this.Parents_dgv.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.Parents_dgv_RowStateChanged);
            this.Parents_dgv.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Parents_dgv_UserRowsAdded);
            this.Parents_dgv.Enter += new System.EventHandler(this.Parents_dgv_Enter);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // surname
            // 
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "Фамилия";
            this.surname.Name = "surname";
            this.surname.Width = 173;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.Width = 173;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Адрес";
            this.address.Name = "address";
            this.address.Width = 173;
            // 
            // parentBindingSource
            // 
            this.parentBindingSource.DataMember = "Parent";
            this.parentBindingSource.DataSource = this.kindergartenDBDataSetBindingSource;
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
            // parentBindingSource1
            // 
            this.parentBindingSource1.DataMember = "Parent";
            this.parentBindingSource1.DataSource = this.kindergartenDBDataSetBindingSource;
            // 
            // childofparentfk0BindingSource
            // 
            this.childofparentfk0BindingSource.DataMember = "Child_of_parent_fk0";
            this.childofparentfk0BindingSource.DataSource = this.parentBindingSource;
            // 
            // childofparentfk0BindingSource1
            // 
            this.childofparentfk0BindingSource1.DataMember = "Child_of_parent_fk0";
            this.childofparentfk0BindingSource1.DataSource = this.parentBindingSource;
            // 
            // childBindingSource
            // 
            this.childBindingSource.DataMember = "Child";
            this.childBindingSource.DataSource = this.kindergartenDBDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Родители";
            // 
            // childrenOfParent_dsv
            // 
            this.childrenOfParent_dsv.AllowUserToAddRows = false;
            this.childrenOfParent_dsv.AllowUserToDeleteRows = false;
            this.childrenOfParent_dsv.AutoGenerateColumns = false;
            this.childrenOfParent_dsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childrenOfParent_dsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cop2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dOBDataGridViewTextBoxColumn,
            this.group_name});
            this.childrenOfParent_dsv.DataSource = this.childofparent2BindingSource1;
            this.childrenOfParent_dsv.Location = new System.Drawing.Point(12, 297);
            this.childrenOfParent_dsv.Name = "childrenOfParent_dsv";
            this.childrenOfParent_dsv.ReadOnly = true;
            this.childrenOfParent_dsv.Size = new System.Drawing.Size(662, 141);
            this.childrenOfParent_dsv.TabIndex = 3;
            // 
            // id_cop2
            // 
            this.id_cop2.DataPropertyName = "id";
            this.id_cop2.HeaderText = "id";
            this.id_cop2.Name = "id_cop2";
            this.id_cop2.ReadOnly = true;
            this.id_cop2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_cop2.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 210;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 209;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // group_name
            // 
            this.group_name.DataPropertyName = "group_name";
            this.group_name.HeaderText = "Группа";
            this.group_name.Name = "group_name";
            this.group_name.ReadOnly = true;
            this.group_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.group_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // childofparent2BindingSource1
            // 
            this.childofparent2BindingSource1.DataMember = "Child_of_parent2";
            this.childofparent2BindingSource1.DataSource = this.kindergartenDBDataSetBindingSource;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.kindergartenDBDataSetBindingSource;
            // 
            // childBindingSource1
            // 
            this.childBindingSource1.DataMember = "Child";
            this.childBindingSource1.DataSource = this.kindergartenDBDataSetBindingSource;
            // 
            // childofparentfk0BindingSource2
            // 
            this.childofparentfk0BindingSource2.DataMember = "Child_of_parent_fk0";
            this.childofparentfk0BindingSource2.DataSource = this.parentBindingSource;
            // 
            // childofparentfk1BindingSource
            // 
            this.childofparentfk1BindingSource.DataMember = "Child_of_parent_fk1";
            this.childofparentfk1BindingSource.DataSource = this.childBindingSource;
            // 
            // childofparent2BindingSource
            // 
            this.childofparent2BindingSource.DataMember = "Child_of_parent2";
            this.childofparent2BindingSource.DataSource = this.kindergartenDBDataSetBindingSource;
            // 
            // parentBindingSource2
            // 
            this.parentBindingSource2.DataMember = "Parent";
            this.parentBindingSource2.DataSource = this.kindergartenDBDataSetBindingSource;
            // 
            // saveChildren
            // 
            this.saveChildren.Location = new System.Drawing.Point(520, 9);
            this.saveChildren.Name = "saveChildren";
            this.saveChildren.Size = new System.Drawing.Size(154, 23);
            this.saveChildren.TabIndex = 7;
            this.saveChildren.Text = "Сохранить изменения";
            this.saveChildren.UseVisualStyleBackColor = true;
            this.saveChildren.Click += new System.EventHandler(this.saveChildren_Click);
            // 
            // ChildOfParentRB
            // 
            this.ChildOfParentRB.AutoSize = true;
            this.ChildOfParentRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChildOfParentRB.Location = new System.Drawing.Point(12, 263);
            this.ChildOfParentRB.Name = "ChildOfParentRB";
            this.ChildOfParentRB.Size = new System.Drawing.Size(165, 28);
            this.ChildOfParentRB.TabIndex = 9;
            this.ChildOfParentRB.TabStop = true;
            this.ChildOfParentRB.Text = "Дети родителя";
            this.ChildOfParentRB.UseVisualStyleBackColor = true;
            this.ChildOfParentRB.CheckedChanged += new System.EventHandler(this.ChildOfParentRB_CheckedChanged);
            // 
            // NotChildOfParentRB
            // 
            this.NotChildOfParentRB.AutoSize = true;
            this.NotChildOfParentRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotChildOfParentRB.Location = new System.Drawing.Point(183, 263);
            this.NotChildOfParentRB.Name = "NotChildOfParentRB";
            this.NotChildOfParentRB.Size = new System.Drawing.Size(178, 28);
            this.NotChildOfParentRB.TabIndex = 10;
            this.NotChildOfParentRB.TabStop = true;
            this.NotChildOfParentRB.Text = "Остальные дети";
            this.NotChildOfParentRB.UseVisualStyleBackColor = true;
            this.NotChildOfParentRB.CheckedChanged += new System.EventHandler(this.NotChildOfParentRB_CheckedChanged);
            // 
            // MakeParentBtn
            // 
            this.MakeParentBtn.Location = new System.Drawing.Point(367, 268);
            this.MakeParentBtn.Name = "MakeParentBtn";
            this.MakeParentBtn.Size = new System.Drawing.Size(307, 23);
            this.MakeParentBtn.TabIndex = 11;
            this.MakeParentBtn.Text = "Связать/Отвязать выделенных родителя и ребенка";
            this.MakeParentBtn.UseVisualStyleBackColor = true;
            this.MakeParentBtn.Click += new System.EventHandler(this.MakeParentBtn_Click);
            // 
            // parentTableAdapter
            // 
            this.parentTableAdapter.ClearBeforeFill = true;
            // 
            // child_of_parentTableAdapter
            // 
            this.child_of_parentTableAdapter.ClearBeforeFill = true;
            // 
            // childTableAdapter
            // 
            this.childTableAdapter.ClearBeforeFill = true;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // child_of_parent2TableAdapter
            // 
            this.child_of_parent2TableAdapter.ClearBeforeFill = true;
            // 
            // ParentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 447);
            this.Controls.Add(this.MakeParentBtn);
            this.Controls.Add(this.NotChildOfParentRB);
            this.Controls.Add(this.ChildOfParentRB);
            this.Controls.Add(this.saveChildren);
            this.Controls.Add(this.childrenOfParent_dsv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parents_dgv);
            this.Name = "ParentsForm";
            this.Load += new System.EventHandler(this.ParentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Parents_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childofparentfk0BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childofparentfk0BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfParent_dsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childofparent2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childofparentfk0BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childofparentfk1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childofparent2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Parents_dgv;
        private System.Windows.Forms.BindingSource kindergartenDBDataSetBindingSource;
        private KindergartenDBDataSet kindergartenDBDataSet;
        private System.Windows.Forms.BindingSource parentBindingSource;
        private KindergartenDBDataSetTableAdapters.ParentTableAdapter parentTableAdapter;
        private System.Windows.Forms.BindingSource childofparentfk0BindingSource;
        private KindergartenDBDataSetTableAdapters.Child_of_parentTableAdapter child_of_parentTableAdapter;
        private System.Windows.Forms.BindingSource childofparentfk0BindingSource1;
        private System.Windows.Forms.BindingSource childBindingSource;
        private KindergartenDBDataSetTableAdapters.ChildTableAdapter childTableAdapter;
        private System.Windows.Forms.BindingSource parentBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView childrenOfParent_dsv;
        private System.Windows.Forms.BindingSource childBindingSource1;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private KindergartenDBDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.BindingSource childofparentfk0BindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource childofparentfk1BindingSource;
        private System.Windows.Forms.BindingSource childofparent2BindingSource1;
        private System.Windows.Forms.BindingSource childofparent2BindingSource;
        private KindergartenDBDataSetTableAdapters.Child_of_parent2TableAdapter child_of_parent2TableAdapter;
        private System.Windows.Forms.BindingSource parentBindingSource2;
        private System.Windows.Forms.Button saveChildren;
        private System.Windows.Forms.RadioButton ChildOfParentRB;
        private System.Windows.Forms.RadioButton NotChildOfParentRB;
        private System.Windows.Forms.Button MakeParentBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cop2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_name;
    }
}