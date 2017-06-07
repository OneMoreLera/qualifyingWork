namespace ForDeeploma
{
    partial class NewSubject
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
            this.subjName = new System.Windows.Forms.TextBox();
            this.subjDescription = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.NameL = new System.Windows.Forms.Label();
            this.DescrL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subjName
            // 
            this.subjName.Location = new System.Drawing.Point(101, 15);
            this.subjName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subjName.Name = "subjName";
            this.subjName.Size = new System.Drawing.Size(256, 22);
            this.subjName.TabIndex = 0;
            // 
            // subjDescription
            // 
            this.subjDescription.Location = new System.Drawing.Point(101, 47);
            this.subjDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subjDescription.Multiline = true;
            this.subjDescription.Name = "subjDescription";
            this.subjDescription.Size = new System.Drawing.Size(256, 202);
            this.subjDescription.TabIndex = 1;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(257, 257);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(101, 28);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Отменить";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(148, 257);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(101, 28);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Location = new System.Drawing.Point(17, 18);
            this.NameL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(72, 17);
            this.NameL.TabIndex = 9;
            this.NameL.Text = "Название";
            // 
            // DescrL
            // 
            this.DescrL.AutoSize = true;
            this.DescrL.Location = new System.Drawing.Point(17, 50);
            this.DescrL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescrL.Name = "DescrL";
            this.DescrL.Size = new System.Drawing.Size(74, 17);
            this.DescrL.TabIndex = 10;
            this.DescrL.Text = "Описание";
            // 
            // NewSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 306);
            this.Controls.Add(this.DescrL);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.subjDescription);
            this.Controls.Add(this.subjName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewSubject";
            this.Text = "Предмет";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddSubject_FormClosed);
            this.Load += new System.EventHandler(this.AddSubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subjName;
        private System.Windows.Forms.TextBox subjDescription;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Label DescrL;
    }
}