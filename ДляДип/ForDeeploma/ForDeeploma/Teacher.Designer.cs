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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuDG = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ljfdbnmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elfkbnmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bpvtybnmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тестыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.списокПредметовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wEBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инфБезопасностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuDG.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 315);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            // 
            // contextMenuDG
            // 
            this.contextMenuDG.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ljfdbnmToolStripMenuItem,
            this.elfkbnmToolStripMenuItem,
            this.bpvtybnmToolStripMenuItem});
            this.contextMenuDG.Name = "contextMenuDG";
            this.contextMenuDG.Size = new System.Drawing.Size(130, 70);
            // 
            // ljfdbnmToolStripMenuItem
            // 
            this.ljfdbnmToolStripMenuItem.Name = "ljfdbnmToolStripMenuItem";
            this.ljfdbnmToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ljfdbnmToolStripMenuItem.Text = "lj,fdbnm";
            // 
            // elfkbnmToolStripMenuItem
            // 
            this.elfkbnmToolStripMenuItem.Name = "elfkbnmToolStripMenuItem";
            this.elfkbnmToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.elfkbnmToolStripMenuItem.Text = "elfkbnm";
            // 
            // bpvtybnmToolStripMenuItem
            // 
            this.bpvtybnmToolStripMenuItem.Name = "bpvtybnmToolStripMenuItem";
            this.bpvtybnmToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.bpvtybnmToolStripMenuItem.Text = "bpvtybnm";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.списокПредметовToolStripMenuItem,
            this.wEBToolStripMenuItem,
            this.инфБезопасностьToolStripMenuItem});
            this.тестыToolStripMenuItem.Name = "тестыToolStripMenuItem";
            this.тестыToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.тестыToolStripMenuItem.Text = "Тесты";
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Студент";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Группа";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Название теста";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Оценка";
            this.Column4.Name = "Column4";
            // 
            // списокПредметовToolStripMenuItem
            // 
            this.списокПредметовToolStripMenuItem.Name = "списокПредметовToolStripMenuItem";
            this.списокПредметовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.списокПредметовToolStripMenuItem.Text = "АИС";
            this.списокПредметовToolStripMenuItem.Click += new System.EventHandler(this.списокПредметовToolStripMenuItem_Click);
            // 
            // wEBToolStripMenuItem
            // 
            this.wEBToolStripMenuItem.Name = "wEBToolStripMenuItem";
            this.wEBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wEBToolStripMenuItem.Text = "WEB";
            // 
            // инфБезопасностьToolStripMenuItem
            // 
            this.инфБезопасностьToolStripMenuItem.Name = "инфБезопасностьToolStripMenuItem";
            this.инфБезопасностьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.инфБезопасностьToolStripMenuItem.Text = "Инф. безопасность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Группа";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ПКС-11",
            "ПКС-21",
            "ПКС-31",
            "ПКС-41"});
            this.comboBox1.Location = new System.Drawing.Point(161, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Выберите группу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Студент";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(66, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(66, 84);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Моисеева Т.И.",
            "Колесников В.Г."});
            this.comboBox2.Location = new System.Drawing.Point(161, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "Выберите студента";
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 448);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Teacher_FormClosed);
            this.Load += new System.EventHandler(this.Teacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuDG.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuDG;
        private System.Windows.Forms.ToolStripMenuItem ljfdbnmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elfkbnmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bpvtybnmToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тестыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem списокПредметовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wEBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инфБезопасностьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}