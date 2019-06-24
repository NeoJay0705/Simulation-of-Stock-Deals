namespace LoginForm
{
    partial class Register
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
            this.endButton = new System.Windows.Forms.Button();
            this.passageLable = new System.Windows.Forms.Label();
            this.accountLable = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.PasswordMessage = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.accountBox = new System.Windows.Forms.TextBox();
            this.AccountMessage = new System.Windows.Forms.Label();
            this.StatusLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // endButton
            // 
            this.endButton.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.endButton.Location = new System.Drawing.Point(357, 193);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(120, 42);
            this.endButton.TabIndex = 18;
            this.endButton.Text = "結束";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // passageLable
            // 
            this.passageLable.AutoSize = true;
            this.passageLable.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.passageLable.Location = new System.Drawing.Point(52, 124);
            this.passageLable.Name = "passageLable";
            this.passageLable.Size = new System.Drawing.Size(82, 24);
            this.passageLable.TabIndex = 17;
            this.passageLable.Text = "密碼：";
            // 
            // accountLable
            // 
            this.accountLable.AutoSize = true;
            this.accountLable.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.accountLable.Location = new System.Drawing.Point(52, 79);
            this.accountLable.Name = "accountLable";
            this.accountLable.Size = new System.Drawing.Size(82, 24);
            this.accountLable.TabIndex = 16;
            this.accountLable.Text = "帳號：";
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("PMingLiU", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SendButton.Location = new System.Drawing.Point(56, 193);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(120, 42);
            this.SendButton.TabIndex = 15;
            this.SendButton.Text = "送出";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // PasswordMessage
            // 
            this.PasswordMessage.AutoSize = true;
            this.PasswordMessage.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PasswordMessage.Location = new System.Drawing.Point(433, 124);
            this.PasswordMessage.Name = "PasswordMessage";
            this.PasswordMessage.Size = new System.Drawing.Size(176, 24);
            this.PasswordMessage.TabIndex = 14;
            this.PasswordMessage.Text = "PasswordMessage";
            this.PasswordMessage.Visible = false;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.passwordBox.Location = new System.Drawing.Point(140, 121);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(269, 35);
            this.passwordBox.TabIndex = 13;
            // 
            // accountBox
            // 
            this.accountBox.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.accountBox.Location = new System.Drawing.Point(140, 76);
            this.accountBox.Name = "accountBox";
            this.accountBox.Size = new System.Drawing.Size(269, 35);
            this.accountBox.TabIndex = 12;
            // 
            // AccountMessage
            // 
            this.AccountMessage.AutoSize = true;
            this.AccountMessage.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMessage.Location = new System.Drawing.Point(433, 79);
            this.AccountMessage.Name = "AccountMessage";
            this.AccountMessage.Size = new System.Drawing.Size(164, 24);
            this.AccountMessage.TabIndex = 11;
            this.AccountMessage.Text = "AccountMessage";
            this.AccountMessage.Visible = false;
            // 
            // StatusLable
            // 
            this.StatusLable.AutoSize = true;
            this.StatusLable.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StatusLable.Location = new System.Drawing.Point(12, 258);
            this.StatusLable.Name = "StatusLable";
            this.StatusLable.Size = new System.Drawing.Size(116, 24);
            this.StatusLable.TabIndex = 19;
            this.StatusLable.Text = "StatusLable";
            this.StatusLable.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 355);
            this.Controls.Add(this.StatusLable);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.passageLable);
            this.Controls.Add(this.accountLable);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.PasswordMessage);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.accountBox);
            this.Controls.Add(this.AccountMessage);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Label passageLable;
        private System.Windows.Forms.Label accountLable;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label PasswordMessage;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox accountBox;
        private System.Windows.Forms.Label AccountMessage;
        private System.Windows.Forms.Label StatusLable;
    }
}