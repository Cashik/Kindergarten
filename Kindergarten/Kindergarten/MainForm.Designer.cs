namespace Kindergarten
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.родителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emplToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.родителиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // родителиToolStripMenuItem
            // 
            this.родителиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.childsToolStripMenuItem,
            this.parentsToolStripMenuItem1,
            this.groupsToolStripMenuItem,
            this.emplToolStripMenuItem,
            this.должностиToolStripMenuItem});
            this.родителиToolStripMenuItem.Name = "родителиToolStripMenuItem";
            this.родителиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.родителиToolStripMenuItem.Text = "Справочники";
            // 
            // childsToolStripMenuItem
            // 
            this.childsToolStripMenuItem.Name = "childsToolStripMenuItem";
            this.childsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.childsToolStripMenuItem.Text = "Дети";
            this.childsToolStripMenuItem.Click += new System.EventHandler(this.детиToolStripMenuItem_Click);
            // 
            // parentsToolStripMenuItem1
            // 
            this.parentsToolStripMenuItem1.Name = "parentsToolStripMenuItem1";
            this.parentsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.parentsToolStripMenuItem1.Text = "Родители";
            this.parentsToolStripMenuItem1.Click += new System.EventHandler(this.родителиToolStripMenuItem1_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.groupsToolStripMenuItem.Text = "Группы";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // emplToolStripMenuItem
            // 
            this.emplToolStripMenuItem.Name = "emplToolStripMenuItem";
            this.emplToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.emplToolStripMenuItem.Text = "Сотрудники";
            this.emplToolStripMenuItem.Click += new System.EventHandler(this.emplToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Приветствуем вас, ";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLbl.Location = new System.Drawing.Point(115, 121);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(55, 17);
            this.userNameLbl.TabIndex = 2;
            this.userNameLbl.TabStop = true;
            this.userNameLbl.Text = "Гость.";
            this.userNameLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 159);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "База данных детского сада";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem родителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem childsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emplToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel userNameLbl;
    }
}

