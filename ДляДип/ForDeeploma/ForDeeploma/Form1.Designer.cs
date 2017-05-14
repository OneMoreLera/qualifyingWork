namespace ForDeeploma
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LoginSelector = new System.Windows.Forms.ComboBox();
            this.passwdInput = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.LoginError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Войдите в систему";
            // 
            // LoginSelector
            // 
            this.LoginSelector.FormattingEnabled = true;
            this.LoginSelector.Location = new System.Drawing.Point(12, 48);
            this.LoginSelector.Name = "LoginSelector";
            this.LoginSelector.Size = new System.Drawing.Size(145, 21);
            this.LoginSelector.TabIndex = 1;
            // 
            // passwdInput
            // 
            this.passwdInput.Location = new System.Drawing.Point(12, 98);
            this.passwdInput.Name = "passwdInput";
            this.passwdInput.PasswordChar = '*';
            this.passwdInput.Size = new System.Drawing.Size(145, 20);
            this.passwdInput.TabIndex = 3;
            this.passwdInput.UseSystemPasswordChar = true;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(44, 27);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(80, 13);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Пользователь";
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Location = new System.Drawing.Point(62, 77);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(45, 13);
            this.passwdLabel.TabIndex = 5;
            this.passwdLabel.Text = "Пароль";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(47, 126);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 6;
            this.Login.Text = "Войти";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(47, 157);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 7;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // LoginError
            // 
            this.LoginError.AutoSize = true;
            this.LoginError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginError.Location = new System.Drawing.Point(0, 237);
            this.LoginError.MaximumSize = new System.Drawing.Size(175, 0);
            this.LoginError.Name = "LoginError";
            this.LoginError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginError.Size = new System.Drawing.Size(0, 13);
            this.LoginError.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 250);
            this.Controls.Add(this.LoginError);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.passwdLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwdInput);
            this.Controls.Add(this.LoginSelector);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LoginSelector;
        private System.Windows.Forms.TextBox passwdInput;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label LoginError;
    }
}

