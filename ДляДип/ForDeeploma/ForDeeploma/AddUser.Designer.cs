namespace ForDeeploma
{
    partial class AddUser
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
            this.SurnameT = new System.Windows.Forms.TextBox();
            this.NameT = new System.Windows.Forms.TextBox();
            this.PatronymT = new System.Windows.Forms.TextBox();
            this.passwdT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupSelector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление пользователя";
            // 
            // SurnameT
            // 
            this.SurnameT.Location = new System.Drawing.Point(93, 25);
            this.SurnameT.Name = "SurnameT";
            this.SurnameT.Size = new System.Drawing.Size(126, 20);
            this.SurnameT.TabIndex = 1;
            // 
            // NameT
            // 
            this.NameT.Location = new System.Drawing.Point(93, 51);
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(126, 20);
            this.NameT.TabIndex = 2;
            // 
            // PatronymT
            // 
            this.PatronymT.Location = new System.Drawing.Point(93, 77);
            this.PatronymT.Name = "PatronymT";
            this.PatronymT.Size = new System.Drawing.Size(126, 20);
            this.PatronymT.TabIndex = 3;
            // 
            // passwdT
            // 
            this.passwdT.Location = new System.Drawing.Point(93, 130);
            this.passwdT.Name = "passwdT";
            this.passwdT.Size = new System.Drawing.Size(126, 20);
            this.passwdT.TabIndex = 5;
            this.passwdT.TextChanged += new System.EventHandler(this.passwdT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Группа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Пароль";
            // 
            // groupSelector
            // 
            this.groupSelector.FormattingEnabled = true;
            this.groupSelector.Items.AddRange(new object[] {
            "ПКС-21",
            "ПКС-31",
            "ПКС-41",
            "КС-21",
            "КС-31",
            "КС-41",
            "ЭО-21",
            "ЭО-31",
            "ЭО-41",
            "БУ-21",
            "БУ-31",
            "Преподаватель"});
            this.groupSelector.Location = new System.Drawing.Point(93, 103);
            this.groupSelector.Name = "groupSelector";
            this.groupSelector.Size = new System.Drawing.Size(126, 21);
            this.groupSelector.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 198);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupSelector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwdT);
            this.Controls.Add(this.PatronymT);
            this.Controls.Add(this.NameT);
            this.Controls.Add(this.SurnameT);
            this.Controls.Add(this.label1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddUser_FormClosed);
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SurnameT;
        private System.Windows.Forms.TextBox NameT;
        private System.Windows.Forms.TextBox PatronymT;
        private System.Windows.Forms.TextBox passwdT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox groupSelector;
        private System.Windows.Forms.Button button1;
    }
}