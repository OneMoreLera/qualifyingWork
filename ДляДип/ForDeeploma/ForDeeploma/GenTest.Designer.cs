namespace ForDeeploma
{
    partial class GenTest
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
            this.Split = new System.Windows.Forms.SplitContainer();
            this.SubjectList = new System.Windows.Forms.ComboBox();
            this.PickupQuest = new System.Windows.Forms.Button();
            this.ListCount = new System.Windows.Forms.NumericUpDown();
            this.CancelGen = new System.Windows.Forms.Button();
            this.SaveTest = new System.Windows.Forms.Button();
            this.CandidateListView = new System.Windows.Forms.DataGridView();
            this.DescrL = new System.Windows.Forms.Label();
            this.DescrQuestT = new System.Windows.Forms.TextBox();
            this.SubjL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Split)).BeginInit();
            this.Split.Panel1.SuspendLayout();
            this.Split.Panel2.SuspendLayout();
            this.Split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandidateListView)).BeginInit();
            this.SuspendLayout();
            // 
            // Split
            // 
            this.Split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Split.Location = new System.Drawing.Point(0, 0);
            this.Split.Name = "Split";
            this.Split.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Split.Panel1
            // 
            this.Split.Panel1.Controls.Add(this.SubjL);
            this.Split.Panel1.Controls.Add(this.DescrQuestT);
            this.Split.Panel1.Controls.Add(this.DescrL);
            this.Split.Panel1.Controls.Add(this.SubjectList);
            this.Split.Panel1.Controls.Add(this.PickupQuest);
            this.Split.Panel1.Controls.Add(this.ListCount);
            // 
            // Split.Panel2
            // 
            this.Split.Panel2.Controls.Add(this.CancelGen);
            this.Split.Panel2.Controls.Add(this.SaveTest);
            this.Split.Panel2.Controls.Add(this.CandidateListView);
            this.Split.Size = new System.Drawing.Size(408, 353);
            this.Split.SplitterDistance = 69;
            this.Split.TabIndex = 0;
            // 
            // SubjectList
            // 
            this.SubjectList.FormattingEnabled = true;
            this.SubjectList.Location = new System.Drawing.Point(68, 43);
            this.SubjectList.Name = "SubjectList";
            this.SubjectList.Size = new System.Drawing.Size(182, 21);
            this.SubjectList.TabIndex = 2;
            // 
            // PickupQuest
            // 
            this.PickupQuest.Location = new System.Drawing.Point(325, 43);
            this.PickupQuest.Name = "PickupQuest";
            this.PickupQuest.Size = new System.Drawing.Size(75, 21);
            this.PickupQuest.TabIndex = 1;
            this.PickupQuest.Text = "Подобрать";
            this.PickupQuest.UseVisualStyleBackColor = true;
            this.PickupQuest.Click += new System.EventHandler(this.PickupQuest_Click);
            // 
            // ListCount
            // 
            this.ListCount.Location = new System.Drawing.Point(256, 44);
            this.ListCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ListCount.Name = "ListCount";
            this.ListCount.Size = new System.Drawing.Size(63, 20);
            this.ListCount.TabIndex = 0;
            this.ListCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CancelGen
            // 
            this.CancelGen.Location = new System.Drawing.Point(249, 254);
            this.CancelGen.Name = "CancelGen";
            this.CancelGen.Size = new System.Drawing.Size(75, 23);
            this.CancelGen.TabIndex = 2;
            this.CancelGen.Text = "Отменить";
            this.CancelGen.UseVisualStyleBackColor = true;
            this.CancelGen.Click += new System.EventHandler(this.CancelGen_Click);
            // 
            // SaveTest
            // 
            this.SaveTest.Location = new System.Drawing.Point(330, 254);
            this.SaveTest.Name = "SaveTest";
            this.SaveTest.Size = new System.Drawing.Size(75, 23);
            this.SaveTest.TabIndex = 1;
            this.SaveTest.Text = "Сохранить";
            this.SaveTest.UseVisualStyleBackColor = true;
            this.SaveTest.Click += new System.EventHandler(this.SaveTest_Click);
            // 
            // CandidateListView
            // 
            this.CandidateListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CandidateListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidateListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.CandidateListView.Location = new System.Drawing.Point(0, 0);
            this.CandidateListView.Name = "CandidateListView";
            this.CandidateListView.Size = new System.Drawing.Size(408, 248);
            this.CandidateListView.TabIndex = 0;
            // 
            // DescrL
            // 
            this.DescrL.AutoSize = true;
            this.DescrL.Location = new System.Drawing.Point(5, 6);
            this.DescrL.Name = "DescrL";
            this.DescrL.Size = new System.Drawing.Size(57, 26);
            this.DescrL.TabIndex = 3;
            this.DescrL.Text = "Описание\r\nтеста";
            // 
            // DescrQuestT
            // 
            this.DescrQuestT.Location = new System.Drawing.Point(68, 3);
            this.DescrQuestT.Multiline = true;
            this.DescrQuestT.Name = "DescrQuestT";
            this.DescrQuestT.Size = new System.Drawing.Size(332, 34);
            this.DescrQuestT.TabIndex = 4;
            // 
            // SubjL
            // 
            this.SubjL.AutoSize = true;
            this.SubjL.Location = new System.Drawing.Point(5, 47);
            this.SubjL.Name = "SubjL";
            this.SubjL.Size = new System.Drawing.Size(52, 13);
            this.SubjL.TabIndex = 5;
            this.SubjL.Text = "Предмет";
            // 
            // GenTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 353);
            this.Controls.Add(this.Split);
            this.Name = "GenTest";
            this.Text = "GenTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GenTest_FormClosed);
            this.Load += new System.EventHandler(this.GenTest_Load);
            this.Split.Panel1.ResumeLayout(false);
            this.Split.Panel1.PerformLayout();
            this.Split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Split)).EndInit();
            this.Split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandidateListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Split;
        private System.Windows.Forms.Button PickupQuest;
        private System.Windows.Forms.NumericUpDown ListCount;
        private System.Windows.Forms.Button CancelGen;
        private System.Windows.Forms.Button SaveTest;
        private System.Windows.Forms.DataGridView CandidateListView;
        private System.Windows.Forms.ComboBox SubjectList;
        private System.Windows.Forms.Label SubjL;
        private System.Windows.Forms.TextBox DescrQuestT;
        private System.Windows.Forms.Label DescrL;
    }
}