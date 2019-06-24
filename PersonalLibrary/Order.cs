using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary
{
    public class Order : IOrderable
    {
        void IOrderable.Order(string number, string name, double costPrice, int unit, TradeStatus tradingStatus)
        {
        }
    }
}