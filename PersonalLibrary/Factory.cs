using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary
{
    public class Factory
    {
        #region 資料初始化

        public static QuoteStock LoadStockList(string name, string number, double close)
        {
            return new QuoteStock(name, number, close);
        }

        #endregion 資料初始化

        #region 註冊、登入(出)相關

        public static StatusOfAccount CreateAccount(string account, string password)
        {
            StockAccount.MemberList = new StockAccount(account, password);
            if (Member.StatusOfRegister == StatusOfAccount.REPEAT)
            {
                return StatusOfAccount.REPEAT;
            }
            else
            {
                StockAccount.MemberList = new StockAccount(account, password);
                return StatusOfAccount.SUCCESS;
            }
        }

        public static StatusOfAccount InspectAccount(string account, string password)
        {
            StatusOfAccount LoginStatus = StatusOfAccount.ACCOUNTERROR;
            Member.ConnectAccount = "";
            foreach (StockAccount checkIdenity in Member.memberList)
            {
                if (checkIdenity.Account != account || checkIdenity.Password != password)
                {
                    if (checkIdenity.Account != account)
                        LoginStatus = StatusOfAccount.ACCOUNTERROR;
                    else if (checkIdenity.Password != password)
                    {
                        LoginStatus = StatusOfAccount.PASSWORDERROR;
                        break;
                    }
                }
                else
                {
                    LoginStatus = StatusOfAccount.SUCCESS;
                    Member.ConnectAccount = account;
                    break;
                }
            }
            return LoginStatus;
        }

        public static StockAccount LinkAccount()
        {
            int Count = 0;
            foreach (StockAccount checkAccount in Member.memberList)
            {
                if (checkAccount.Account == Member.ConnectAccount)
                    break;
                Count++;
            }
            return (StockAccount)Member.memberList[Count];
        }

        public static void ClearBuffer()
        {
            Member.ConnectAccount = "";
        }

        #endregion 註冊、登入(出)相關

        #region 交易介面相關

        public static string LimitShowhand(string box)
        {
            int MaxShowhand;
            int.TryParse(box, out MaxShowhand);
            if (MaxShowhand > StockAccount.SynchronizeAccount.MaxShowhand)
                MaxShowhand = StockAccount.SynchronizeAccount.MaxShowhand;
            else if (MaxShowhand > 10000000)
                MaxShowhand = 10000000;
            else if (MaxShowhand <= 0)
                MaxShowhand = 0;
            return MaxShowhand.ToString();
        }

        public static string LimitTradingUnit(string box, string number, string maxShowhand)
        {
            int Unit;
            int.TryParse(box, out Unit);
            double selectedprice = Factory.GetStockClose(number);
            int TMaxShowhand;
            int.TryParse(maxShowhand, out TMaxShowhand);
            int maxTradingUnit = Factory.MaxTradingUnit(selectedprice, TMaxShowhand);
            if (Unit <= 0)
                return "0";
            else if (Unit > maxTradingUnit)
                return maxTradingUnit.ToString();
            else
                return Unit.ToString();
        }

        public static int MaxTradingUnit(double selectedprice, int maxShowhand)
        {
            int ReturnValue = (int)((double)maxShowhand / (selectedprice * 1000));
            if (selectedprice <= 0)
                ReturnValue = 99;
            else if (ReturnValue < 1)
                ReturnValue = 0;
            return ReturnValue;
        }

        public static string GetPayCost(string tradingUnit, string number)
        {
            int TradingUnit = int.Parse(tradingUnit);
            double EstimateCost = TradingUnit * Factory.GetStockClose(number) * 1000;
            return EstimateCost.ToString();
        }

        public static double GetStockClose(string number)
        {
            foreach (QuoteStock goods in QuoteStock.quoteStockList)
            {
                if (goods.Number == number)
                    return goods.Close;
            }
            return 0.0;
        }

        public static string[] QuoteListToCombo()
        {
            string[] number = new string[QuoteStock.quoteStockList.Count];
            int i = 0;
            foreach (QuoteStock s in QuoteStock.quoteStockList)
            {
                number[i] = s.Number;
                i++;
            }
            return number;
        }

        public static double GetNotImplemented()
        {
            double NotImplemented = 0;
            foreach (Clinched stock in StockAccount.SynchronizeAccount.holdingList)
            {
                foreach (QuoteStock quoteStock in QuoteStock.quoteStockList)
                {
                    if (stock.Number == quoteStock.Number)
                    {
                        NotImplemented += Factory.ToRounding(quoteStock.Close * 1000 * stock.TotalUnit - stock.TotalCost, 2);
                    }
                }
            }
            return NotImplemented;
        }

        #endregion 交易介面相關

        #region 帳目介面相關

        public static string[] HoldingListToPersonalAccount(Clinched stock)
        {
            string[] hadStock = new string[6];

            hadStock[0] = stock.Number;
            hadStock[1] = stock.Name;
            hadStock[2] = ((stock.TotalCost / stock.TotalUnit) / 1000).ToString();
            hadStock[3] = stock.TotalUnit.ToString();
            hadStock[4] = stock.AverageCost.ToString();
            foreach (QuoteStock quoteStock in QuoteStock.quoteStockList)
            {
                if (stock.Number == quoteStock.Number)
                {
                    hadStock[5] = (quoteStock.Close * 1000 * stock.TotalUnit - stock.TotalCost).ToString();
                }
            }

            return hadStock;
        }

        #endregion 帳目介面相關

        #region 下單相關

        public static string CreatePosition(string number, string buyingPrice, string buyingUnit, string maxShowhand)
        {
            double NeedCost = double.Parse(buyingPrice) * int.Parse(buyingUnit) * 1000;
            foreach (QuoteStock stock in QuoteStock.quoteStockList)
            {
                if (stock.Number == number)
                {
                    if (NeedCost > int.Parse(maxShowhand))
                        return "餘額不足";
                    else if (stock.Close < double.Parse(buyingPrice))
                    {
                        Factory.AddToHoldingList(new Clinched(number, stock.Close.ToString(), buyingUnit));

                        return "買進成交";
                    }
                    else
                    {
                        Factory.AddToNoCreateList(new Commited(number, stock.Name, double.Parse(buyingPrice), int.Parse(buyingUnit), TradeStatus.BUY));
                        return "委託成功";
                    }
                }
            }
            return "異常";
        }

        public static string WaitngForCreate(string number, string buyingPrice, string buyingUnit)
        {
            Factory.AddToHoldingList(new Clinched(number, buyingPrice, buyingUnit));
            foreach (Commited waitingStock in StockAccount.SynchronizeAccount.noGetList)
            {
                if (waitingStock.Number == number)
                    waitingStock.HoldStatus = HoldStatus.DELETE;
            }
            return "買進成交";
        }

        public static void AddToNoCreateList(Commited buyingStock)
        {
            StockAccount.SynchronizeAccount.NoGetList = new Commited(buyingStock);
        }

        public static string InversPosition(string number, string sellingPrice, string sellingUnit)
        {
            StatusOfAccount Had = StatusOfAccount.HADNT;
            foreach (Clinched hadStock in StockAccount.SynchronizeAccount.holdingList)
            {
                if (hadStock.Number == number)
                {
                    foreach (QuoteStock stock in QuoteStock.quoteStockList)
                    {
                        if (stock.Number == number)
                        {
                            if (double.Parse(sellingPrice) < stock.Close)
                            {
                                Factory.ClearHoldingList(new Clinched(number, stock.Close.ToString(), sellingUnit));
                                Factory.ClearHoldingList();
                                return "賣出成交";
                            }
                            else if (double.Parse(sellingPrice) > stock.Close)
                            {
                                Factory.AddToNoCreateList(new Commited(number, stock.Name, double.Parse(sellingPrice), int.Parse(sellingUnit), TradeStatus.SELL));
                                return "委託成功";
                            }
                        }
                    }
                    Had = StatusOfAccount.HAD;
                }
            }
            if (Had == StatusOfAccount.HADNT)
                return "庫存不足";
            else
                return "庫存不足";
        }

        public static string WaitingForInvers(string number, string sellingPrice, string sellingUnit)
        {
            Factory.AddToHoldingList(new Clinched(number, sellingPrice, sellingUnit));
            foreach (Commited waitingStock in StockAccount.SynchronizeAccount.noGetList)
            {
                if (waitingStock.Number == number)
                    waitingStock.HoldStatus = HoldStatus.DELETE;
            }
            return "賣出成交";
        }

        public static void AddToNoSellList(Commited sellingStock)
        {
            StockAccount.SynchronizeAccount.NoGetList = new Commited(sellingStock);
        }

        public static void AddToHoldingList(Clinched buyingStock)
        {
            StatusOfAccount Had = StatusOfAccount.HADNT;
            foreach (Clinched haveStock in StockAccount.SynchronizeAccount.holdingList)
            {
                if (haveStock.Number == buyingStock.Number)
                {
                    haveStock.TotalCost += Factory.ToRounding(buyingStock.HoldingCost * buyingStock.HoldingUnit * 1000, 2);
                    haveStock.TotalUnit += buyingStock.HoldingUnit;
                    haveStock.AverageCost = Factory.ToRounding(haveStock.TotalCost / haveStock.TotalUnit, 2);
                    Had = StatusOfAccount.HAD;
                }
            }
            if (Had == StatusOfAccount.HADNT)
                StockAccount.SynchronizeAccount.holdingList.Add(buyingStock);
            StockAccount.SynchronizeAccount.MaxShowhand -= (int)(buyingStock.HoldingCost * buyingStock.HoldingUnit * 1000);
        }

        public static void ClearHoldingList(Clinched sellingStock)
        {
            int Count = 0;
            foreach (Clinched haveStock in StockAccount.SynchronizeAccount.holdingList)
            {
                if (haveStock.Number == sellingStock.Number)
                {
                    haveStock.TotalCost -= Factory.ToRounding(sellingStock.HoldingCost * sellingStock.HoldingUnit, 2);
                    haveStock.TotalUnit -= sellingStock.HoldingUnit;
                    if (haveStock.TotalUnit > 0)
                        haveStock.AverageCost = Factory.ToRounding(haveStock.TotalCost / haveStock.TotalUnit, 2);
                    else
                        haveStock.HoldStatus = HoldStatus.DELETE;
                    StockAccount.SynchronizeAccount.Gross += (int)Factory.ToRounding(Factory.ToRounding((sellingStock.HoldingCost - haveStock.AverageCost / 1000) * sellingStock.HoldingUnit * 1000, 2), 0);
                }
                Count++;
            }
            StockAccount.SynchronizeAccount.MaxShowhand += (int)(sellingStock.HoldingCost * sellingStock.HoldingUnit * 1000);
        }

        public static void ClearHoldingList()
        {
            int ListLength = StockAccount.SynchronizeAccount.holdingList.Count;
            int Click = 0;
            for (int Count = 0; Count < ListLength; ++Count)
            {
                if (StockAccount.SynchronizeAccount.holdingList[Click].HoldStatus == HoldStatus.DELETE)
                {
                    StockAccount.SynchronizeAccount.holdingList.RemoveAt(Count);
                    Click--;
                }
                Click++;
            }
        }

        public static void InspectNoGetList()
        {
            foreach (Commited waitingStock in StockAccount.SynchronizeAccount.noGetList)
                foreach (QuoteStock stock in QuoteStock.quoteStockList)
                    if (waitingStock.Number == stock.Number)
                        if (waitingStock.TradingStatus == TradeStatus.BUY)
                            if (stock.Close < waitingStock.CostPrice)
                                Factory.WaitngForCreate(waitingStock.Number, stock.Close.ToString(), waitingStock.Unit.ToString());
                            else if (waitingStock.TradingStatus == TradeStatus.SELL)
                                if (stock.Close > waitingStock.CostPrice)
                                    Factory.WaitingForInvers(waitingStock.Number, stock.Close.ToString(), waitingStock.Unit.ToString());
        }

        public static void IsClinch()
        {
            int n = StockAccount.SynchronizeAccount.noGetList.Count;
            int click = 0;
            for (int Count = 0; Count < n; ++Count)
            {
                if (StockAccount.SynchronizeAccount.noGetList[click].HoldStatus == HoldStatus.DELETE)
                {
                    StockAccount.SynchronizeAccount.noGetList.RemoveAt(click);
                    click--;
                }
                click++;
            }
        }

        #endregion 下單相關

        #region 報價相關

        public static Random RndTick = new Random();
        public static Random RndDirection = new Random();

        public static int RandomTick()
        {
            int ActualTick;
            ActualTick = Factory.RndDirection.Next(0, 2) == 0 ? Factory.RndTick.Next(0, 3) : -Factory.RndTick.Next(0, 3);
            return ActualTick;
        }

        public static void SetMiniTick()
        {
            foreach (QuoteStock stock in QuoteStock.quoteStockList)
            {
                if (stock.Close >= 1000.0)
                    stock.MiniTick = 5.0;
                else if (stock.Close >= 500.0)
                    stock.MiniTick = 1.0;
                else if (stock.Close >= 100.0)
                    stock.MiniTick = 0.5;
                else if (stock.Close >= 50.0)
                    stock.MiniTick = 0.1;
                else if (stock.Close >= 10.0)
                    stock.MiniTick = 0.05;
                else
                    stock.MiniTick = 0.01;
            }
        }

        public static double GetMiniTick(string number)
        {
            foreach (QuoteStock stock in QuoteStock.quoteStockList)
            {
                if (stock.Number == number)
                    return stock.MiniTick;
            }
            return 0.0;
        }

        public static void RenewQuote()
        {
            Factory.SetMiniTick();

            foreach (QuoteStock stock in QuoteStock.quoteStockList)
            {
                if (stock.Close > stock.LastClose * 1.1)
                    stock.Close = Factory.ToRounding(stock.LastClose * 1.1, 2);
                else if (stock.Close < stock.LastClose * 0.9)
                    stock.Close = Factory.ToRounding(stock.LastClose * 0.9, 2);
                else
                    stock.Close += Factory.ToRounding(stock.MiniTick * Factory.RandomTick(), 2);
            }
        }

        public static string SetStockBound(string number, string tradingPrice)
        {
            foreach (QuoteStock stock in QuoteStock.quoteStockList)
            {
                if (stock.Number == number)
                {
                    double TradingPrice;
                    if (double.Parse(tradingPrice) > stock.LastClose * 1.1)
                        return (stock.LastClose * 1.1).ToString();
                    else if (double.Parse(tradingPrice) < stock.LastClose * 0.9)
                        return (stock.LastClose * 0.9).ToString();
                    else if (!double.TryParse(tradingPrice, out TradingPrice))
                        return stock.Close.ToString();
                    else
                        return tradingPrice;
                }
            }
            return "";
        }

        #endregion 報價相關

        #region 其他方法

        public static double ToRounding(double transNumner, int dotAfterSite)
        {
            int handleOne;
            int handleTwo;
            handleOne = (int)(transNumner * Math.Pow(10, dotAfterSite + 1));
            handleTwo = handleOne % 10;
            handleOne /= 10;
            if (handleTwo >= 5)
                handleOne++;
            transNumner = handleOne / Math.Pow(10, dotAfterSite);
            return transNumner;
        }

        public static int SetTimer()
        {
            return 1000;
        }

        #endregion 其他方法
    }
}