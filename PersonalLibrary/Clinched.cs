using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary
{
    public enum HoldStatus { DELETE, HAD }

    public class Clinched : Member
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public double HoldingCost { get; set; }
        public int HoldingUnit { get; set; }

        public HoldStatus HoldStatus { get; set; }
        public double TotalCost { get; set; }
        public int TotalUnit { get; set; }
        public double AverageCost { get; set; }
        public int Gross { get; set; }

        public Clinched()
        { }

        public Clinched(string number, string buyingPrice, string buyingUnit)
        {
            this.Number = number;
            this.HoldingCost = double.Parse(buyingPrice);
            this.HoldingUnit = int.Parse(buyingUnit);
            foreach (QuoteStock stock in QuoteStock.quoteStockList)
            {
                if (stock.Number == number)
                    this.Name = stock.Name;
            }
            this.HoldStatus = HoldStatus.HAD;

            this.TotalCost = this.HoldingCost * this.HoldingUnit * 1000;
            this.TotalUnit = this.HoldingUnit;
            this.AverageCost = this.TotalCost / this.TotalUnit;
            this.Gross = 0;
        }
    }
}