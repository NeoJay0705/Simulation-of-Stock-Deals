using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary
{
    public abstract class Quote
    {
        #region 屬性

        public string Number { get; set; }
        public string Name { get; set; }
        public double Close { get; set; }
        public double MiniTick { get; set; }
        public double LastClose { get; set; }

        public Quote()
        {
        }

        #endregion 屬性

        #region 建構式

        public Quote(string number, string name, double close, double miniTick, double lastClose)
        {
            this.Number = number;
            this.Name = name;
            this.Close = close;
            this.MiniTick = miniTick;
            this.LastClose = lastClose;
        }

        #endregion 建構式
    }
}