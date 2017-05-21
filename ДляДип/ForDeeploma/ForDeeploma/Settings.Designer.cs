namespace ForDeeploma
{
    partial class Settings
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
            this.serverLabel = new System.Windows.Forms.Label();
            this.serverT = new System.Windows.Forms.TextBox();
            this.databaseT = new System.Windows.Forms.TextBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.uidT = new System.Windows.Forms.TextBox();
            this.uidLabel = new System.Windows.Forms.Label();
            this.passwordT = new System.Windows.Forms.TextBox();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.CheckConf = new System.Windows.Forms.Button();
            this.WriteConf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(45, 13);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(47, 13);
            this.serverLabel.TabIndex = 0;
            this.serverLabel.Text = "Сервер:";
            // 
            // serverT
            // 
            this.serverT.Location = new System.Drawing.Point(18, 32);
            this.serverT.Name = "serverT";
            this.serverT.Size = new System.Drawing.Size(100, 20);
            this.serverT.TabIndex = 1;
            // 
            // databaseT
            // 
            this.databaseT.Location = new System.Drawing.Point(18, 77);
            this.databaseT.Name = "databaseT";
            this.databaseT.Size = new System.Drawing.Size(100, 20);
            this.databaseT.TabIndex = 3;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(32, 58);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(72, 13);
            this.databaseLabel.TabIndex = 2;
            this.databaseLabel.Text = "База данных";
            // 
            // uidT
            // 
            this.uidT.Location = new System.Drawing.Point(18, 122);
            this.uidT.Name = "uidT";
            this.uidT.Size = new System.Drawing.Size(100, 20);
            this.uidT.TabIndex = 5;
            // 
            // uidLabel
            // 
            this.uidLabel.AutoSize = true;
            this.uidLabel.Location = new System.Drawing.Point(28, 103);
            this.uidLabel.Name = "uidLabel";
            this.uidLabel.Size = new System.Drawing.Size(80, 13);
            this.uidLabel.TabIndex = 4;
            this.uidLabel.Text = "Пользователь";
            // 
            // passwordT
            // 
            this.passwordT.Location = new System.Drawing.Point(18, 167);
            this.passwordT.Name = "passwordT";
            this.passwordT.Size = new System.Drawing.Size(100, 20);
            this.passwordT.TabIndex = 7;
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Location = new System.Drawing.Point(46, 148);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(45, 13);
            this.passwdLabel.TabIndex = 6;
            this.passwdLabel.Text = "Пароль";
            // 
            // CheckConf
            // 
            this.CheckConf.Location = new System.Drawing.Point(18, 194);
            this.CheckConf.Name = "CheckConf";
            this.CheckConf.Size = new System.Drawing.Size(100, 23);
            this.CheckConf.TabIndex = 8;
            this.CheckConf.Text = "Проверить";
            this.CheckConf.UseVisualStyleBackColor = true;
            this.CheckConf.Click += new System.EventHandler(this.CheckConf_Click);
            // 
            // WriteConf
            // 
            this.WriteConf.Location = new System.Drawing.Point(18, 224);
            this.WriteConf.Name = "WriteConf";
            this.WriteConf.Size = new System.Drawing.Size(100, 23);
            this.WriteConf.TabIndex = 9;
            this.WriteConf.Text = "Записать";
            this.WriteConf.UseVisualStyleBackColor = true;
            this.WriteConf.Click += new System.EventHandler(this.WriteConf_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(134, 263);
            this.Controls.Add(this.WriteConf);
            this.Controls.Add(this.CheckConf);
            this.Controls.Add(this.passwordT);
            this.Controls.Add(this.passwdLabel);
            this.Controls.Add(this.uidT);
            this.Controls.Add(this.uidLabel);
            this.Controls.Add(this.databaseT);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.serverT);
            this.Controls.Add(this.serverLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.TextBox serverT;
        private System.Windows.Forms.TextBox databaseT;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.TextBox uidT;
        private System.Windows.Forms.Label uidLabel;
        private System.Windows.Forms.TextBox passwordT;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.Button CheckConf;
        private System.Windows.Forms.Button WriteConf;
    }
}