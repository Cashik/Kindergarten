namespace Kindergarten
{
    partial class GroupsForm
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
            this.groups_dgv = new System.Windows.Forms.DataGridView();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergartenDBDataSet = new Kindergarten.KindergartenDBDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveGroupsBtn = new System.Windows.Forms.Button();
            this.groupTableAdapter = new Kindergarten.KindergartenDBDataSetTableAdapters.GroupTableAdapter();
            this.id_group_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.training_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groups_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groups_dgv
            // 
            this.groups_dgv.AutoGenerateColumns = false;
            this.groups_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groups_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_group_dgv,
            this.nameDataGridViewTextBoxColumn,
            this.training_plan});
            this.groups_dgv.DataSource = this.groupBindingSource;
            this.groups_dgv.Location = new System.Drawing.Point(12, 43);
            this.groups_dgv.Name = "groups_dgv";
            this.groups_dgv.Size = new System.Drawing.Size(457, 258);
            this.groups_dgv.TabIndex = 0;
            this.groups_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groups_dgv_CellContentClick);
            this.groups_dgv.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.groups_dgv_UserAddedRow);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.kindergartenDBDataSet;
            // 
            // kindergartenDBDataSet
            // 
            this.kindergartenDBDataSet.DataSetName = "KindergartenDBDataSet";
            this.kindergartenDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Группы";
            // 
            // SaveGroupsBtn
            // 
            this.SaveGroupsBtn.Location = new System.Drawing.Point(319, 12);
            this.SaveGroupsBtn.Name = "SaveGroupsBtn";
            this.SaveGroupsBtn.Size = new System.Drawing.Size(150, 23);
            this.SaveGroupsBtn.TabIndex = 7;
            this.SaveGroupsBtn.Text = "Сохранить изменения";
            this.SaveGroupsBtn.UseVisualStyleBackColor = true;
            this.SaveGroupsBtn.Click += new System.EventHandler(this.SaveGroupsBtn_Click);
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // id_group_dgv
            // 
            this.id_group_dgv.DataPropertyName = "id";
            this.id_group_dgv.HeaderText = "id";
            this.id_group_dgv.Name = "id_group_dgv";
            this.id_group_dgv.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // training_plan
            // 
            this.training_plan.DataPropertyName = "training_plan";
            this.training_plan.HeaderText = "Описание группы";
            this.training_plan.Name = "training_plan";
            this.training_plan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.training_plan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.training_plan.Width = 314;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 313);
            this.Controls.Add(this.SaveGroupsBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groups_dgv);
            this.Name = "GroupsForm";
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groups_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView groups_dgv;
        private System.Windows.Forms.Label label2;
        private KindergartenDBDataSet kindergartenDBDataSet;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private KindergartenDBDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.Button SaveGroupsBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_group_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn training_plan;
    }
}