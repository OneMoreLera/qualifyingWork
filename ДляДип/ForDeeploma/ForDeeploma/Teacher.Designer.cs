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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuDG = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ljfdbnmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elfkbnmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bpvtybnmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuDG.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы вошли как ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 424);
            this.dataGridView1.TabIndex = 1;
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
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Teacher_FormClosed);
            this.Load += new System.EventHandler(this.Teacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuDG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuDG;
        private System.Windows.Forms.ToolStripMenuItem ljfdbnmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elfkbnmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bpvtybnmToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}