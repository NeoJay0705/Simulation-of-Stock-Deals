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
    public partial class PersonalAccount : Form
    {
        private StockAccount SynchronizeAccount;

        public PersonalAccount()
        {
            InitializeComponent();
            SynchronizeAccount = Factory.LinkAccount();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void RenewAccount_Click(object sender, EventArgs e)
        {
            this.AccountGridView.Rows.Clear();
            string[] ListOfHad;
            foreach (Clinched hadStock in StockAccount.SynchronizeAccount.holdingList)
            {
                ListOfHad = Factory.HoldingListToPersonalAccount(hadStock);
                this.AccountGridView.Rows.Add(ListOfHad);
            }
        }
    }
}