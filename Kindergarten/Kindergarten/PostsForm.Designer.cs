namespace Kindergarten
{
    partial class PostsForm
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
            this.SavePostsBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.posts_dgv = new System.Windows.Forms.DataGridView();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergartenDBDataSet = new Kindergarten.KindergartenDBDataSet();
            this.postTableAdapter = new Kindergarten.KindergartenDBDataSetTableAdapters.PostTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.posts_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SavePostsBtn
            // 
            this.SavePostsBtn.Location = new System.Drawing.Point(263, 12);
            this.SavePostsBtn.Name = "SavePostsBtn";
            this.SavePostsBtn.Size = new System.Drawing.Size(150, 23);
            this.SavePostsBtn.TabIndex = 10;
            this.SavePostsBtn.Text = "Сохранить изменения";
            this.SavePostsBtn.UseVisualStyleBackColor = true;
            this.SavePostsBtn.Click += new System.EventHandler(this.SavePostsBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Должности";
            // 
            // posts_dgv
            // 
            this.posts_dgv.AutoGenerateColumns = false;
            this.posts_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posts_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.posts_dgv.DataSource = this.postBindingSource;
            this.posts_dgv.Location = new System.Drawing.Point(12, 43);
            this.posts_dgv.Name = "posts_dgv";
            this.posts_dgv.Size = new System.Drawing.Size(401, 258);
            this.posts_dgv.TabIndex = 8;
            this.posts_dgv.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.groups_dgv_UserAddedRow);
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
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 358;
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 309);
            this.Controls.Add(this.SavePostsBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.posts_dgv);
            this.Name = "PostsForm";
            this.Load += new System.EventHandler(this.PostsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posts_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SavePostsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView posts_dgv;
        private KindergartenDBDataSet kindergartenDBDataSet;
        private System.Windows.Forms.BindingSource postBindingSource;
        private KindergartenDBDataSetTableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}