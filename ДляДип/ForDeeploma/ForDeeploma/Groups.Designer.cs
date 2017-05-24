namespace ForDeeploma
{
    partial class Groups
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
            this.NameT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rolesSelector = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameT
            // 
            this.NameT.Location = new System.Drawing.Point(12, 25);
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(234, 20);
            this.NameT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // DescriptionT
            // 
            this.DescriptionT.Location = new System.Drawing.Point(12, 64);
            this.DescriptionT.Multiline = true;
            this.DescriptionT.Name = "DescriptionT";
            this.DescriptionT.Size = new System.Drawing.Size(234, 103);
            this.DescriptionT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Роль";
            // 
            // rolesSelector
            // 
            this.rolesSelector.FormattingEnabled = true;
            this.rolesSelector.Location = new System.Drawing.Point(12, 191);
            this.rolesSelector.Name = "rolesSelector";
            this.rolesSelector.Size = new System.Drawing.Size(234, 21);
            this.rolesSelector.TabIndex = 5;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(170, 227);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(76, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 262);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.rolesSelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescriptionT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameT);
            this.Name = "Groups";
            this.Text = "Groups";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Groups_FormClosed);
            this.Load += new System.EventHandler(this.Groups_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rolesSelector;
        private System.Windows.Forms.Button SaveButton;
    }
}