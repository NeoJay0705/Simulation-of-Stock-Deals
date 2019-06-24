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
    public partial class Trading : Form
    {
        // public static Timer Timer1 = new Timer();
        private bool Selected;

        public Trading()
        {
            InitializeComponent();

            Member.SynchronizeAccount = Factory.LinkAccount();
            this.AccountName.Text = StockAccount.SynchronizeAccount.Account;
            this.TradeUnit.Text = "1";
            this.MaxShowhandBox.Text = StockAccount.SynchronizeAccount.MaxShowhand.ToString();
            this.StockList.DataSource = Factory.QuoteListToCombo();
            this.timer1.Tick += new EventHandler(timer1_Tick);
            this.FormClosing += new FormClosingEventHandler(Trading_Closing);
            Selected = false;
        }

        private void Trading_Closing(Object sender, FormClosingEventArgs e)
        {
            this.timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Factory.RenewQuote();
            GridViewInitial();
            this.EstimateCostLable.Text = Factory.GetPayCost(this.TradeUnit.Text, this.StockList.SelectedItem.ToString());
            this.MaxShowhandBox.Text = StockAccount.SynchronizeAccount.MaxShowhand.ToString();
            Factory.InspectNoGetList();
            Factory.IsClinch();
            this.NotGetLable.Text = Factory.GetNotImplemented().ToString();
            this.GrossLable.Text = StockAccount.SynchronizeAccount.Gross.ToString();
        }

        private void TradeUnit_TextChanged(object sender, EventArgs e)
        {
            if (Selected)
                this.TradeUnit.Text = Factory.LimitTradingUnit(this.TradeUnit.Text, this.StockList.SelectedItem.ToString(), this.MaxShowhandBox.Text);
            else
                this.TradeUnit.Text = Factory.LimitTradingUnit(this.TradeUnit.Text, "0000", this.MaxShowhandBox.Text);
        }

        private void MaxShowhandBox_TextChanged(object sender, EventArgs e)
        {
            //StockAccount.SynchronizeAccount.MaxShowhand = Factory.SetMaxShowhand(this.MaxShowhandBox.Text);
            this.MaxShowhandBox.Text = Factory.LimitShowhand(this.MaxShowhandBox.Text);
        }

        private void StockList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected = true;
            this.SetPriceBox.Text = Factory.GetStockClose(this.StockList.SelectedItem.ToString()).ToString();
            GridViewInitial();
            this.timer1.Interval = Factory.SetTimer();
            this.timer1.Start();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            new PersonalAccount().ShowDialog();
        }

        private void BuyButtom_Click(object sender, EventArgs e)
        {
            if (Selected)
                MessageBox.Show(Factory.CreatePosition(this.StockList.SelectedItem.ToString(), this.SetPriceBox.Text, this.TradeUnit.Text, this.MaxShowhandBox.Text));
        }

        private void SellButtom_Click(object sender, EventArgs e)
        {
            if (Selected)
                MessageBox.Show(Factory.InversPosition(this.StockList.SelectedItem.ToString(), this.SetPriceBox.Text, this.TradeUnit.Text));
        }

        private void SetPriceBox_TextChanged(object sender, EventArgs e)
        {
            if (Selected)
                this.SetPriceBox.Text = Factory.SetStockBound(this.StockList.SelectedItem.ToString(), this.SetPriceBox.Text);
        }
    }
}