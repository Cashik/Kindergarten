namespace Kindergarten
{
    partial class LoginForm
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
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.kindergartenDBDataSet1 = new Kindergarten.KindergartenDBDataSet();
            this.userTableAdapter1 = new Kindergarten.KindergartenDBDataSetTableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(110, 85);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(108, 20);
            this.exit.TabIndex = 22;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Пароль:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Логин:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.info.FlatAppearance.BorderSize = 0;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.info.ForeColor = System.Drawing.Color.Black;
            this.info.Location = new System.Drawing.Point(5, 85);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(99, 20);
            this.info.TabIndex = 19;
            this.info.Text = "Справка";
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(6, 59);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(213, 20);
            this.loginBtn.TabIndex = 18;
            this.loginBtn.Text = "Вход";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.White;
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTxt.ForeColor = System.Drawing.Color.Black;
            this.passwordTxt.Location = new System.Drawing.Point(80, 31);
            this.passwordTxt.MinimumSize = new System.Drawing.Size(2, 20);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(139, 20);
            this.passwordTxt.TabIndex = 17;
            this.passwordTxt.Text = "password";
            // 
            // loginTxt
            // 
            this.loginTxt.BackColor = System.Drawing.Color.White;
            this.loginTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTxt.ForeColor = System.Drawing.Color.Black;
            this.loginTxt.Location = new System.Drawing.Point(81, 7);
            this.loginTxt.MinimumSize = new System.Drawing.Size(2, 20);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(139, 20);
            this.loginTxt.TabIndex = 16;
            this.loginTxt.Text = "user";
            // 
            // kindergartenDBDataSet1
            // 
            this.kindergartenDBDataSet1.DataSetName = "KindergartenDBDataSet";
            this.kindergartenDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 110);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.loginTxt);
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox loginTxt;
        private KindergartenDBDataSet kindergartenDBDataSet1;
        private KindergartenDBDataSetTableAdapters.UserTableAdapter userTableAdapter1;
    }
}