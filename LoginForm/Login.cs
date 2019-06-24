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
    public enum DataStatus { SUCCESS, ERROR }

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Member.memberList.Add(new StockAccount());
            QuoteStock.quoteStockList.Add(new QuoteStock());
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //作弊
            //this.accountBox.Text = "CSHARP274";
            //this.passwordBox.Text = "CSHARP274";
            this.accountMessage.Visible = false;
            this.passwordMessage.Visible = false;
            if (Factory.InspectAccount(this.accountBox.Text, this.passwordBox.Text) == StatusOfAccount.SUCCESS)
            {
                this.Visible = false;
                new Trading().ShowDialog();
                Factory.ClearBuffer();
                this.Visible = true;
            }
            else
            {
                if (Factory.InspectAccount(this.accountBox.Text, this.passwordBox.Text) == StatusOfAccount.ACCOUNTERROR)
                {
                    this.accountMessage.Text = "帳號錯誤";
                    this.accountMessage.Visible = true;
                }
                else
                {
                    this.passwordMessage.Text = "密碼錯誤";
                    this.passwordMessage.Visible = true;
                }
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            new Register().Show();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}