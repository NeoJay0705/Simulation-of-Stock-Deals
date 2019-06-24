using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary
{
    public enum TradeStatus { BUY, SELL }

    public class Commited : Member
    {
        public List<Commited> noGetList = new List<Commited>();

        public Commited NoGetList
        {
            set { this.noGetList.Add(value); }
        }

        public string Number { get; set; }
        public string Name { get; set; }
        public double CostPrice { get; set; }

        public int Unit { get; set; }
        public TradeStatus TradingStatus { get; set; }
        public HoldStatus HoldStatus { get; set; }

        public Commited()
        { }

        public Commited(string number, string name, double costPrice, int unit, TradeStatus status)
        {
            this.Number = number;
            this.Name = name;
            this.CostPrice = costPrice;
            this.Unit = unit;
            this.TradingStatus = status;
        }

        public Commited(Commited stock)
            : this(stock.Number, stock.Name, stock.CostPrice, stock.Unit, stock.TradingStatus)
        {
        }
    }
}