namespace ForDeeploma
{
    partial class SelectedQuestion
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
            this.QuestT = new System.Windows.Forms.TextBox();
            this.QuestL = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Answers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuestT
            // 
            this.QuestT.Location = new System.Drawing.Point(78, 13);
            this.QuestT.Name = "QuestT";
            this.QuestT.Size = new System.Drawing.Size(368, 22);
            this.QuestT.TabIndex = 0;
            // 
            // QuestL
            // 
            this.QuestL.AutoSize = true;
            this.QuestL.Location = new System.Drawing.Point(10, 16);
            this.QuestL.Name = "QuestL";
            this.QuestL.Size = new System.Drawing.Size(60, 17);
            this.QuestL.TabIndex = 1;
            this.QuestL.Text = "Вопрос:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(78, 41);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(368, 378);
            this.checkedListBox1.TabIndex = 2;
            // 
            // Answers
            // 
            this.Answers.AutoSize = true;
            this.Answers.Location = new System.Drawing.Point(10, 41);
            this.Answers.Name = "Answers";
            this.Answers.Size = new System.Drawing.Size(62, 17);
            this.Answers.TabIndex = 3;
            this.Answers.Text = "Ответы:";
            // 
            // SelectedQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 441);
            this.Controls.Add(this.Answers);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.QuestL);
            this.Controls.Add(this.QuestT);
            this.Name = "SelectedQuestion";
            this.Text = "SelectedQuestion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectedQuestion_FormClosed);
            this.Load += new System.EventHandler(this.SelectedQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuestT;
        private System.Windows.Forms.Label QuestL;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label Answers;
    }
}