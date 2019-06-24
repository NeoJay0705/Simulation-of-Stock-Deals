using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary
{
    public class QuoteStock : Quote
    {
        public static List<QuoteStock> quoteStockList = new List<QuoteStock>();

        public QuoteStock(string number, string name, double close)
        {
            this.Number = number;
            this.Name = name;
            this.Close = close;
            this.MiniTick = Factory.GetMiniTick(number);
            this.LastClose = close;
        }

        public QuoteStock()
        {
            //市食品業
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1227", "佳格", 79.7));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1216", "統一", 59.2));
            //市電腦設備
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2357", "華碩", 278.5));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2301", "光寶科", 46.75));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2395", "研華", 264));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("4938", "和碩", 82.3));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2382", "廣達", 66.8));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2353", "宏碁", 14.9));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("3231", "緯創", 23.45));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2356", "英業達", 24.9));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("5264", "鎧勝-KY", 118));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("6414", "樺漢", 531));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2324", "仁寶", 19.3));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2377", "微星", 79.8));
            //市電機機械
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1590", "亞德客-KY", 269));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2049", "上銀", 171));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1536", "和大", 154.5));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1504", "東元", 27.25));
            //市電子通路
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("3702", "大聯大", 37.4));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2347", "聯強", 34.75));
            //市電子組件
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("4958", "臻鼎-KY", 69.4));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2385", "群光", 78));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2059", "川湖", 404));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2308", "台達電", 166));
            //市鋼鐵業
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2002", "中鋼", 22.2));
            //市金融業
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2887", "台新金", 11.9));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2884", "玉山金", 18.05));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2885", "元大金", 11.35));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2834", "臺企銀", 8.07));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2823", "中壽", 29.35));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2882", "國泰金", 40.65));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2890", "永豐金", 9.36));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2888", "新光金", 6.99));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2881", "富邦金", 46.5));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2892", "第一金", 16.9));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2883", "開發金", 8.05));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2880", "華南金", 16.35));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2886", "兆豐金", 22.5));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("5880", "合庫金", 14));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2801", "彰銀", 16.3));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2891", "中信金", 18.5));
            //市通信網路
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("3682", "亞太電", 10.6));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2498", "宏達電", 84.3));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2412", "中華電", 112));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("4904", "遠傳", 73));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("3045", "台灣大", 114.5));
            //市貿易百貨
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2912", "統一超", 250.5));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2915", "潤泰全", 50.2));
            //市觀光業
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2723", "美食-KY", 315));
            //市航運業
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2618", "長榮航", 14.65));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2610", "華航", 9.57));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2603", "長榮", 12.95));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2634", "漢翔", 43.4));
            //市紡纖業
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1402", "遠東新", 23.8));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1476", "儒鴻", 387));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1434", "福懋", 30.2));
            //市玻陶業
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1802", "台玻", 15.15));
            //市油電燃氣
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("6505", "台塑化", 94.9));
            //市汽車業
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2201", "裕隆", 27.7));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2207", "和泰車", 361.5));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2227", "裕日車", 208));
            //市水泥業
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1101", "台泥", 35.8));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1102", "亞泥", 27.4));
            //市橡膠業
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2105", "正新", 67.4));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2106", "建大", 50.1));
            //市建材營造
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2542", "興富發", 49.35));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2923", "鼎固-KY", 23.5));
            //市塑膠業
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1301", "台塑", 78.7));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1319", "東陽", 71.6));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1303", "南亞", 62.2));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1326", "台化", 85.3));
            //市半導體
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2303", "聯電", 11.75));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2325", "矽品", 47.5));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("6415", "矽力-KY", 470.5));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2330", "台積電", 187.5));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2451", "創見", 92.3));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2311", "日月光", 38.3));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2454", "聯發科", 247));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2408", "南亞科", 39.8));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("6239", "力成", 82.5));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2379", "瑞昱", 113));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("3034", "聯詠", 114));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("3474", "華亞科", 27.3));
            //市化學業
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1717", "長興", 34.4));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("1722", "台肥", 42.2));
            //市其他電子
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2474", "可成", 267));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2354", "鴻準", 89.7));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("6409", "旭隼", 486.5));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2317", "鴻海", 79.8));
            //市其他
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("9921", "巨大", 212));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("9904", "寶成", 44.35));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("5871", "中租-KY", 56.6));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("9910", "豐泰", 147));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("9917", "中保", 91.6));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("9945", "潤泰新", 38.7));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("9914", "美利達", 142));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("8464", "億豐", 406));
            //市光電業
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("2409", "友達", 11.85));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("3008", "大立光", 3830));
            QuoteStock.quoteStockList.Add(Factory.LoadStockList("3481", "群創", 10.9));
            Factory.SetMiniTick();
        }
    }
}