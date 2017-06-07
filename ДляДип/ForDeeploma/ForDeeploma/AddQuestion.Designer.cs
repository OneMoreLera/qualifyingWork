namespace ForDeeploma
{
    partial class AddQuestion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NewAswer = new System.Windows.Forms.TextBox();
            this.AddingCh = new System.Windows.Forms.CheckBox();
            this.QuestionT = new System.Windows.Forms.TextBox();
            this.QuestL = new System.Windows.Forms.Label();
            this.SubjectL = new System.Windows.Forms.Label();
            this.SubjectList = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubjectList);
            this.panel1.Controls.Add(this.SubjectL);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.QuestionT);
            this.panel1.Controls.Add(this.QuestL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 171);
            this.panel1.TabIndex = 0;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(3, 139);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(309, 23);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.NewAswer);
            this.groupBox1.Controls.Add(this.AddingCh);
            this.groupBox1.Location = new System.Drawing.Point(3, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новый ответ";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(224, 46);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(143, 45);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NewAswer
            // 
            this.NewAswer.Location = new System.Drawing.Point(30, 19);
            this.NewAswer.Name = "NewAswer";
            this.NewAswer.Size = new System.Drawing.Size(270, 20);
            this.NewAswer.TabIndex = 2;
            // 
            // AddingCh
            // 
            this.AddingCh.AutoSize = true;
            this.AddingCh.Location = new System.Drawing.Point(9, 22);
            this.AddingCh.Name = "AddingCh";
            this.AddingCh.Size = new System.Drawing.Size(15, 14);
            this.AddingCh.TabIndex = 3;
            this.AddingCh.UseVisualStyleBackColor = true;
            // 
            // QuestionT
            // 
            this.QuestionT.Location = new System.Drawing.Point(72, 36);
            this.QuestionT.Name = "QuestionT";
            this.QuestionT.Size = new System.Drawing.Size(231, 20);
            this.QuestionT.TabIndex = 1;
            // 
            // QuestL
            // 
            this.QuestL.AutoSize = true;
            this.QuestL.Location = new System.Drawing.Point(12, 39);
            this.QuestL.Name = "QuestL";
            this.QuestL.Size = new System.Drawing.Size(47, 13);
            this.QuestL.TabIndex = 0;
            this.QuestL.Text = "Вопрос:";
            // 
            // SubjectL
            // 
            this.SubjectL.AutoSize = true;
            this.SubjectL.Location = new System.Drawing.Point(12, 10);
            this.SubjectL.Name = "SubjectL";
            this.SubjectL.Size = new System.Drawing.Size(55, 13);
            this.SubjectL.TabIndex = 6;
            this.SubjectL.Text = "Предмет:";
            // 
            // SubjectList
            // 
            this.SubjectList.FormattingEnabled = true;
            this.SubjectList.Location = new System.Drawing.Point(73, 6);
            this.SubjectList.Name = "SubjectList";
            this.SubjectList.Size = new System.Drawing.Size(230, 21);
            this.SubjectList.TabIndex = 7;
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 171);
            this.Controls.Add(this.panel1);
            this.Name = "AddQuestion";
            this.Text = "AddQuestion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuestion_FormClosed);
            this.Load += new System.EventHandler(this.AddQuestion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox NewAswer;
        private System.Windows.Forms.CheckBox AddingCh;
        private System.Windows.Forms.TextBox QuestionT;
        private System.Windows.Forms.Label QuestL;
        private System.Windows.Forms.ComboBox SubjectList;
        private System.Windows.Forms.Label SubjectL;
    }
}