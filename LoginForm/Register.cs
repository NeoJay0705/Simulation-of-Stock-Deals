using PersonalLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (Factory.CreateAccount(this.accountBox.Text, this.passwordBox.Text) == StatusOfAccount.REPEAT)
            {
                StatusLable.Text = "帳號重複";
                StatusLable.Visible = true;
            }
            else
            {
                StatusLable.Text = "註冊成功";
                StatusLable.Visible = true;
            }
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}