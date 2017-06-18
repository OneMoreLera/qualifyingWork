namespace ForDeeploma
{
    partial class Teacher
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тестыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПредметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.добавитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВопросовПоПредметуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.добавитьТестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокТестовПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelLayout = new System.Windows.Forms.Panel();
            this.QuestSubjContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.подробностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestSubjContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.подробностиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.QuestSubjContext.SuspendLayout();
            this.TestSubjContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.тестыToolStripMenuItem,
            this.статистикаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // тестыToolStripMenuItem
            // 
            this.тестыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПредметToolStripMenuItem,
            this.toolStripSeparator2,
            this.добавитьВопросToolStripMenuItem,
            this.списокВопросовПоПредметуToolStripMenuItem,
            this.toolStripSeparator1,
            this.добавитьТестToolStripMenuItem,
            this.списокТестовПоToolStripMenuItem});
            this.тестыToolStripMenuItem.Name = "тестыToolStripMenuItem";
            this.тестыToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.тестыToolStripMenuItem.Text = "Тесты";
            // 
            // добавитьПредметToolStripMenuItem
            // 
            this.добавитьПредметToolStripMenuItem.Name = "добавитьПредметToolStripMenuItem";
            this.добавитьПредметToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.добавитьПредметToolStripMenuItem.Text = "Добавить предмет";
            this.добавитьПредметToolStripMenuItem.Click += new System.EventHandler(this.добавитьПредметToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // добавитьВопросToolStripMenuItem
            // 
            this.добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            this.добавитьВопросToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.добавитьВопросToolStripMenuItem.Text = "Добавить вопрос";
            this.добавитьВопросToolStripMenuItem.Click += new System.EventHandler(this.добавитьВопросToolStripMenuItem_Click);
            // 
            // списокВопросовПоПредметуToolStripMenuItem
            // 
            this.списокВопросовПоПредметуToolStripMenuItem.Name = "списокВопросовПоПредметуToolStripMenuItem";
            this.списокВопросовПоПредметуToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.списокВопросовПоПредметуToolStripMenuItem.Text = "Список вопросов по";
            this.списокВопросовПоПредметуToolStripMenuItem.Click += new System.EventHandler(this.списокВопросовПоПредметуToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // добавитьТестToolStripMenuItem
            // 
            this.добавитьТестToolStripMenuItem.Name = "добавитьТестToolStripMenuItem";
            this.добавитьТестToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.добавитьТестToolStripMenuItem.Text = "Добавить тест";
            this.добавитьТестToolStripMenuItem.Click += new System.EventHandler(this.добавитьТестToolStripMenuItem_Click);
            // 
            // списокТестовПоToolStripMenuItem
            // 
            this.списокТестовПоToolStripMenuItem.Name = "списокТестовПоToolStripMenuItem";
            this.списокТестовПоToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.списокТестовПоToolStripMenuItem.Text = "Список тестов по";
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // PanelLayout
            // 
            this.PanelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLayout.Location = new System.Drawing.Point(0, 24);
            this.PanelLayout.Name = "PanelLayout";
            this.PanelLayout.Size = new System.Drawing.Size(490, 424);
            this.PanelLayout.TabIndex = 3;
            // 
            // QuestSubjContext
            // 
            this.QuestSubjContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.QuestSubjContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подробностиToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.QuestSubjContext.Name = "QuestSubjContext";
            this.QuestSubjContext.Size = new System.Drawing.Size(150, 48);
            // 
            // подробностиToolStripMenuItem
            // 
            this.подробностиToolStripMenuItem.Name = "подробностиToolStripMenuItem";
            this.подробностиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.подробностиToolStripMenuItem.Text = "Подробности";
            this.подробностиToolStripMenuItem.Click += new System.EventHandler(this.подробностиToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // TestSubjContext
            // 
            this.TestSubjContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TestSubjContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подробностиToolStripMenuItem1,
            this.изменитьToolStripMenuItem1});
            this.TestSubjContext.Name = "contextMenuStrip2";
            this.TestSubjContext.Size = new System.Drawing.Size(150, 48);
            // 
            // подробностиToolStripMenuItem1
            // 
            this.подробностиToolStripMenuItem1.Name = "подробностиToolStripMenuItem1";
            this.подробностиToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.подробностиToolStripMenuItem1.Text = "Подробности";
            this.подробностиToolStripMenuItem1.Click += new System.EventHandler(this.подробностиToolStripMenuItem1_Click);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            this.изменитьToolStripMenuItem1.Click += new System.EventHandler(this.изменитьToolStripMenuItem1_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 448);
            this.Controls.Add(this.PanelLayout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Teacher_FormClosed);
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.QuestSubjContext.ResumeLayout(false);
            this.TestSubjContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тестыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПредметToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel PanelLayout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem добавитьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВопросовПоПредметуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокТестовПоToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip QuestSubjContext;
        private System.Windows.Forms.ToolStripMenuItem подробностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip TestSubjContext;
        private System.Windows.Forms.ToolStripMenuItem подробностиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
    }
}