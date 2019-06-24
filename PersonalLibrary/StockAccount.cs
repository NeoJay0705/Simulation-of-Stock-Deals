using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary
{
    public class StockAccount : Clinched
    {
        public List<Clinched> holdingList = new List<Clinched>();

        public Clinched HoldingList
        {
            set { this.holdingList.Add(value); }
        }

        public List<Commited> noGetList = new List<Commited>();

        public Commited NoGetList
        {
            set { this.noGetList.Add(value); }
        }

        #region 屬性

        public int MaxShowhand { get; set; }

        #endregion 屬性

        #region 建構式

        public StockAccount(string account, string password)
        {
            this.Account = account;
            this.Password = password;
            this.MaxShowhand = 10000000;
            this.Gross = 0;
        }

        public StockAccount()
            : this("CSHARP274", "CSHARP274")
        {
        }

        #endregion 建構式

        #region 方法

        public void CalculateGross()
        {
            foreach (Clinched myStock in this.holdingList)
            {
                this.Gross += (int)Factory.ToRounding(Factory.GetStockClose(myStock.Number) - myStock.HoldingCost, 0);
            }
        }

        #endregion 方法
    }
}