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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LoginSelector = new System.Windows.Forms.ComboBox();
            this.passwdInput = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.LoginError = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Войдите в систему";
            // 
            // LoginSelector
            // 
            this.LoginSelector.FormattingEnabled = true;
            this.LoginSelector.Location = new System.Drawing.Point(16, 59);
            this.LoginSelector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginSelector.Name = "LoginSelector";
            this.LoginSelector.Size = new System.Drawing.Size(192, 24);
            this.LoginSelector.TabIndex = 1;
            // 
            // passwdInput
            // 
            this.passwdInput.Location = new System.Drawing.Point(16, 121);
            this.passwdInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwdInput.Name = "passwdInput";
            this.passwdInput.PasswordChar = '*';
            this.passwdInput.Size = new System.Drawing.Size(192, 22);
            this.passwdInput.TabIndex = 3;
            this.passwdInput.UseSystemPasswordChar = true;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(59, 33);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(101, 17);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Пользователь";
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Location = new System.Drawing.Point(83, 95);
            this.passwdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(57, 17);
            this.passwdLabel.TabIndex = 5;
            this.passwdLabel.Text = "Пароль";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(63, 155);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 28);
            this.Login.TabIndex = 6;
            this.Login.Text = "Войти";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(63, 193);
            this.Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 28);
            this.Close.TabIndex = 7;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // LoginError
            // 
            this.LoginError.AutoSize = true;
            this.LoginError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginError.Location = new System.Drawing.Point(0, 291);
            this.LoginError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginError.MaximumSize = new System.Drawing.Size(233, 0);
            this.LoginError.Name = "LoginError";
            this.LoginError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginError.Size = new System.Drawing.Size(0, 17);
            this.LoginError.TabIndex = 8;
            // 
            // settings
            // 
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Location = new System.Drawing.Point(16, 155);
            this.settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(39, 28);
            this.settings.TabIndex = 9;
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 308);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.LoginError);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.passwdLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwdInput);
            this.Controls.Add(this.LoginSelector);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button settings;
    }
}

