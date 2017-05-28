namespace ForDeeploma
{
    partial class Student
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тестыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокДосутпныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моиРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.порядокПрохожденияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оцениваниеРезультатовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "вы вошли как студент";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестыToolStripMenuItem,
            this.инфоToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // тестыToolStripMenuItem
            // 
            this.тестыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокДосутпныхToolStripMenuItem,
            this.моиРезультатыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.тестыToolStripMenuItem.Name = "тестыToolStripMenuItem";
            this.тестыToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.тестыToolStripMenuItem.Text = "Тесты";
            // 
            // списокДосутпныхToolStripMenuItem
            // 
            this.списокДосутпныхToolStripMenuItem.Name = "списокДосутпныхToolStripMenuItem";
            this.списокДосутпныхToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.списокДосутпныхToolStripMenuItem.Text = "Список тестов";
            // 
            // моиРезультатыToolStripMenuItem
            // 
            this.моиРезультатыToolStripMenuItem.Name = "моиРезультатыToolStripMenuItem";
            this.моиРезультатыToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.моиРезультатыToolStripMenuItem.Text = "Мои результаты";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.выходToolStripMenuItem.Text = "Выйти";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // инфоToolStripMenuItem
            // 
            this.инфоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.порядокПрохожденияToolStripMenuItem,
            this.оцениваниеРезультатовToolStripMenuItem});
            this.инфоToolStripMenuItem.Name = "инфоToolStripMenuItem";
            this.инфоToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.инфоToolStripMenuItem.Text = "Инфо";
            // 
            // порядокПрохожденияToolStripMenuItem
            // 
            this.порядокПрохожденияToolStripMenuItem.Name = "порядокПрохожденияToolStripMenuItem";
            this.порядокПрохожденияToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.порядокПрохожденияToolStripMenuItem.Text = "Порядок прохождения";
            this.порядокПрохожденияToolStripMenuItem.Click += new System.EventHandler(this.порядокПрохожденияToolStripMenuItem_Click);
            // 
            // оцениваниеРезультатовToolStripMenuItem
            // 
            this.оцениваниеРезультатовToolStripMenuItem.Name = "оцениваниеРезультатовToolStripMenuItem";
            this.оцениваниеРезультатовToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.оцениваниеРезультатовToolStripMenuItem.Text = "Оценивание результатов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 229);
            this.dataGridView1.TabIndex = 2;
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 422);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Student";
            this.Text = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_FormClosed);
            this.Load += new System.EventHandler(this.Student_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тестыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокДосутпныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моиРезультатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инфоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem порядокПрохожденияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оцениваниеРезультатовToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}