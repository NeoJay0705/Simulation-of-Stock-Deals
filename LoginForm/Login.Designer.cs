namespace LoginForm
{
    partial class Login
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
            this.accountMessage = new System.Windows.Forms.Label();
            this.accountBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordMessage = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.accountLable = new System.Windows.Forms.Label();
            this.passageLable = new System.Windows.Forms.Label();
            this.endButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // accountMessage
            // 
            this.accountMessage.AutoSize = true;
            this.accountMessage.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.accountMessage.Location = new System.Drawing.Point(425, 82);
            this.accountMessage.Name = "accountMessage";
            this.accountMessage.Size = new System.Drawing.Size(44, 24);
            this.accountMessage.TabIndex = 1;
            this.accountMessage.Text = "null";
            this.accountMessage.Visible = false;
            // 
            // accountBox
            // 
            this.accountBox.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.accountBox.Location = new System.Drawing.Point(132, 79);
            this.accountBox.Name = "accountBox";
            this.accountBox.Size = new System.Drawing.Size(269, 35);
            this.accountBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.passwordBox.Location = new System.Drawing.Point(132, 124);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(269, 35);
            this.passwordBox.TabIndex = 3;
            // 
            // passwordMessage
            // 
            this.passwordMessage.AutoSize = true;
            this.passwordMessage.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.passwordMessage.Location = new System.Drawing.Point(425, 127);
            this.passwordMessage.Name = "passwordMessage";
            this.passwordMessage.Size = new System.Drawing.Size(44, 24);
            this.passwordMessage.TabIndex = 4;
            this.passwordMessage.Text = "null";
            this.passwordMessage.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginButton.Location = new System.Drawing.Point(48, 196);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(120, 42);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "登入";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // accountLable
            // 
            this.accountLable.AutoSize = true;
            this.accountLable.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.accountLable.Location = new System.Drawing.Point(44, 82);
            this.accountLable.Name = "accountLable";
            this.accountLable.Size = new System.Drawing.Size(82, 24);
            this.accountLable.TabIndex = 8;
            this.accountLable.Text = "帳號：";
            // 
            // passageLable
            // 
            this.passageLable.AutoSize = true;
            this.passageLable.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.passageLable.Location = new System.Drawing.Point(44, 127);
            this.passageLable.Name = "passageLable";
            this.passageLable.Size = new System.Drawing.Size(82, 24);
            this.passageLable.TabIndex = 9;
            this.passageLable.Text = "密碼：";
            // 
            // endButton
            // 
            this.endButton.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.endButton.Location = new System.Drawing.Point(207, 196);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(120, 42);
            this.endButton.TabIndex = 10;
            this.endButton.Text = "結束";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.registerButton.Location = new System.Drawing.Point(349, 196);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(120, 42);
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "註冊";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 275);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.passageLable);
            this.Controls.Add(this.accountLable);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordMessage);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.accountBox);
            this.Controls.Add(this.accountMessage);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "登入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accountMessage;
        private System.Windows.Forms.TextBox accountBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordMessage;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label accountLable;
        private System.Windows.Forms.Label passageLable;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button registerButton;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

