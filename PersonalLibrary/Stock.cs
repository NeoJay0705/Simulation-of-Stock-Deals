using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary
{
    public class Stock
    {
        #region Field

        private string stockName;
        private string stockNumber;
        private double bidHigh;
        private double askLow;
        private int bidHigh_Volume;
        private int askLow_Volume;
        private double tickTip;

        #endregion Field

        #region Properties

        public string StockName
        {
            get { return this.stockName; }
            set { this.stockName = value; }
        }

        public string StockNumber
        {
            get { return this.stockNumber; }
            set { this.stockNumber = value; }
        }

        public double BidHigh
        {
            get { return this.bidHigh; }
            set { this.bidHigh = value; }
        }

        public double AskLow
        {
            get { return this.askLow; }
            set { this.askLow = value; }
        }

        public int BidHigh_Volume
        {
            get { return this.bidHigh_Volume; }
            set { this.bidHigh_Volume = value; }
        }

        public int AskLow_Volume
        {
            get { return this.askLow_Volume; }
            set { this.askLow_Volume = value; }
        }

        public double TickTip
        {
            get { return this.tickTip; }
            set { this.tickTip = value; }
        }

        #endregion Properties
    }
}