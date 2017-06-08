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
            this.SubjectList = new System.Windows.Forms.ComboBox();
            this.SubjectL = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NewAswer = new System.Windows.Forms.TextBox();
            this.AddingCh = new System.Windows.Forms.CheckBox();
            this.QuestionT = new System.Windows.Forms.TextBox();
            this.QuestL = new System.Windows.Forms.Label();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 210);
            this.panel1.TabIndex = 0;
            // 
            // SubjectList
            // 
            this.SubjectList.FormattingEnabled = true;
            this.SubjectList.Location = new System.Drawing.Point(97, 7);
            this.SubjectList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubjectList.Name = "SubjectList";
            this.SubjectList.Size = new System.Drawing.Size(305, 24);
            this.SubjectList.TabIndex = 7;
            // 
            // SubjectL
            // 
            this.SubjectL.AutoSize = true;
            this.SubjectL.Location = new System.Drawing.Point(16, 12);
            this.SubjectL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubjectL.Name = "SubjectL";
            this.SubjectL.Size = new System.Drawing.Size(70, 17);
            this.SubjectL.TabIndex = 6;
            this.SubjectL.Text = "Предмет:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(4, 171);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(412, 28);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.NewAswer);
            this.groupBox1.Controls.Add(this.AddingCh);
            this.groupBox1.Location = new System.Drawing.Point(4, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(412, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новый ответ";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(299, 57);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(100, 28);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(191, 55);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 28);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NewAswer
            // 
            this.NewAswer.Location = new System.Drawing.Point(40, 23);
            this.NewAswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewAswer.Name = "NewAswer";
            this.NewAswer.Size = new System.Drawing.Size(359, 22);
            this.NewAswer.TabIndex = 2;
            // 
            // AddingCh
            // 
            this.AddingCh.AutoSize = true;
            this.AddingCh.Location = new System.Drawing.Point(12, 27);
            this.AddingCh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddingCh.Name = "AddingCh";
            this.AddingCh.Size = new System.Drawing.Size(18, 17);
            this.AddingCh.TabIndex = 3;
            this.AddingCh.UseVisualStyleBackColor = true;
            // 
            // QuestionT
            // 
            this.QuestionT.Location = new System.Drawing.Point(96, 44);
            this.QuestionT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuestionT.Name = "QuestionT";
            this.QuestionT.Size = new System.Drawing.Size(307, 22);
            this.QuestionT.TabIndex = 1;
            // 
            // QuestL
            // 
            this.QuestL.AutoSize = true;
            this.QuestL.Location = new System.Drawing.Point(16, 48);
            this.QuestL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestL.Name = "QuestL";
            this.QuestL.Size = new System.Drawing.Size(60, 17);
            this.QuestL.TabIndex = 0;
            this.QuestL.Text = "Вопрос:";
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 210);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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