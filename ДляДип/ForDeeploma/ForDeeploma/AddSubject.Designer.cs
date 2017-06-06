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
            this.subjName.Location = new System.Drawing.Point(76, 12);
            this.subjName.Name = "subjName";
            this.subjName.Size = new System.Drawing.Size(193, 20);
            this.subjName.TabIndex = 0;
            // 
            // subjDescription
            // 
            this.subjDescription.Location = new System.Drawing.Point(76, 38);
            this.subjDescription.Multiline = true;
            this.subjDescription.Name = "subjDescription";
            this.subjDescription.Size = new System.Drawing.Size(193, 165);
            this.subjDescription.TabIndex = 1;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(193, 209);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(76, 23);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Отменить";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(111, 209);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(76, 23);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Location = new System.Drawing.Point(13, 15);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(57, 13);
            this.NameL.TabIndex = 9;
            this.NameL.Text = "Название";
            // 
            // DescrL
            // 
            this.DescrL.AutoSize = true;
            this.DescrL.Location = new System.Drawing.Point(13, 41);
            this.DescrL.Name = "DescrL";
            this.DescrL.Size = new System.Drawing.Size(57, 13);
            this.DescrL.TabIndex = 10;
            this.DescrL.Text = "Описание";
            // 
            // NewSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 249);
            this.Controls.Add(this.DescrL);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.subjDescription);
            this.Controls.Add(this.subjName);
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