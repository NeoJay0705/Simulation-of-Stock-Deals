using PersonalLibrary;

namespace LoginForm
{
    partial class Trading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 報價表
        private void GridViewInitial()
        {
            this.BidGridView.Rows.Clear();
            this.AskGridView.Rows.Clear();
            this.BidGridView.ColumnCount = 2;
            this.AskGridView.ColumnCount = 2;
            double ThisPrice;
            ThisPrice = Factory.GetStockClose(this.StockList.SelectedItem.ToString());
            double ThisMinTick;
            ThisMinTick = Factory.GetMiniTick(this.StockList.SelectedItem.ToString());
            double[] BidPrice =
                {
                    ThisPrice,
                    ThisPrice - ThisMinTick,
                    ThisPrice - ThisMinTick * 2,
                    ThisPrice - ThisMinTick * 3,
                    ThisPrice - ThisMinTick * 4
                };
            double[] AskPrice =
                {
                    ThisPrice + ThisMinTick,
                    ThisPrice + ThisMinTick * 2,
                    ThisPrice + ThisMinTick * 3,
                    ThisPrice + ThisMinTick * 4,
                    ThisPrice + ThisMinTick * 5
                };
            
            this.BidGridView.Rows.Add(BidPrice[0]);
            this.BidGridView.Rows.Add(BidPrice[1]);
            this.BidGridView.Rows.Add(BidPrice[2]);
            this.BidGridView.Rows.Add(BidPrice[3]);
            this.BidGridView.Rows.Add(BidPrice[4]);
            
            this.AskGridView.Rows.Add(AskPrice[0]);
            this.AskGridView.Rows.Add(AskPrice[1]);
            this.AskGridView.Rows.Add(AskPrice[2]);
            this.AskGridView.Rows.Add(AskPrice[3]);
            this.AskGridView.Rows.Add(AskPrice[4]);
        }


        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainerButton = new System.Windows.Forms.Button();
            this.AccountLable = new System.Windows.Forms.Label();
            this.AccountButton = new System.Windows.Forms.Button();
            this.BidGridView = new System.Windows.Forms.DataGridView();
            this.AskGridView = new System.Windows.Forms.DataGridView();
            this.TradeUnit = new System.Windows.Forms.TextBox();
            this.StockList = new System.Windows.Forms.ComboBox();
            this.AccountName = new System.Windows.Forms.Label();
            this.MaxShowhandLable = new System.Windows.Forms.Label();
            this.CreatNumber = new System.Windows.Forms.Label();
            this.CostLable = new System.Windows.Forms.Label();
            this.EstimateCostLable = new System.Windows.Forms.Label();
            this.MaxShowhandBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SetPriceBox = new System.Windows.Forms.TextBox();
            this.BuyButtom = new System.Windows.Forms.Button();
            this.SellButtom = new System.Windows.Forms.Button();
            this.SetPriceLable = new System.Windows.Forms.Label();
            this.NotGetLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrossLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BidGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AskGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainerButton
            // 
            this.MainerButton.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MainerButton.Location = new System.Drawing.Point(358, 203);
            this.MainerButton.Name = "MainerButton";
            this.MainerButton.Size = new System.Drawing.Size(139, 41);
            this.MainerButton.TabIndex = 0;
            this.MainerButton.Text = "主力介入";
            this.MainerButton.UseVisualStyleBackColor = true;
            // 
            // AccountLable
            // 
            this.AccountLable.AutoSize = true;
            this.AccountLable.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountLable.Location = new System.Drawing.Point(6, 15);
            this.AccountLable.Name = "AccountLable";
            this.AccountLable.Size = new System.Drawing.Size(96, 28);
            this.AccountLable.TabIndex = 1;
            this.AccountLable.Text = "帳號：";
            // 
            // AccountButton
            // 
            this.AccountButton.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountButton.Location = new System.Drawing.Point(380, 8);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(117, 41);
            this.AccountButton.TabIndex = 3;
            this.AccountButton.Text = "帳目";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // BidGridView
            // 
            this.BidGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BidGridView.Location = new System.Drawing.Point(11, 293);
            this.BidGridView.Name = "BidGridView";
            this.BidGridView.RowTemplate.Height = 27;
            this.BidGridView.Size = new System.Drawing.Size(240, 324);
            this.BidGridView.TabIndex = 4;
            // 
            // AskGridView
            // 
            this.AskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AskGridView.Location = new System.Drawing.Point(257, 293);
            this.AskGridView.Name = "AskGridView";
            this.AskGridView.RowTemplate.Height = 27;
            this.AskGridView.Size = new System.Drawing.Size(240, 324);
            this.AskGridView.TabIndex = 5;
            // 
            // TradeUnit
            // 
            this.TradeUnit.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TradeUnit.Location = new System.Drawing.Point(99, 53);
            this.TradeUnit.Name = "TradeUnit";
            this.TradeUnit.Size = new System.Drawing.Size(59, 40);
            this.TradeUnit.TabIndex = 7;
            this.TradeUnit.TextChanged += new System.EventHandler(this.TradeUnit_TextChanged);
            // 
            // StockList
            // 
            this.StockList.DisplayMember = "Key";
            this.StockList.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StockList.FormattingEnabled = true;
            this.StockList.Location = new System.Drawing.Point(347, 252);
            this.StockList.Name = "StockList";
            this.StockList.Size = new System.Drawing.Size(150, 35);
            this.StockList.TabIndex = 15;
            this.StockList.SelectedIndexChanged += new System.EventHandler(this.StockList_SelectedIndexChanged);
            // 
            // AccountName
            // 
            this.AccountName.AutoSize = true;
            this.AccountName.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountName.Location = new System.Drawing.Point(94, 15);
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(164, 28);
            this.AccountName.TabIndex = 9;
            this.AccountName.Text = "AccountName";
            // 
            // MaxShowhandLable
            // 
            this.MaxShowhandLable.AutoSize = true;
            this.MaxShowhandLable.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MaxShowhandLable.Location = new System.Drawing.Point(6, 154);
            this.MaxShowhandLable.Name = "MaxShowhandLable";
            this.MaxShowhandLable.Size = new System.Drawing.Size(152, 28);
            this.MaxShowhandLable.TabIndex = 10;
            this.MaxShowhandLable.Text = "最大金額：";
            // 
            // CreatNumber
            // 
            this.CreatNumber.AutoSize = true;
            this.CreatNumber.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CreatNumber.Location = new System.Drawing.Point(6, 65);
            this.CreatNumber.Name = "CreatNumber";
            this.CreatNumber.Size = new System.Drawing.Size(96, 28);
            this.CreatNumber.TabIndex = 11;
            this.CreatNumber.Text = "口數：";
            // 
            // CostLable
            // 
            this.CostLable.AutoSize = true;
            this.CostLable.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CostLable.Location = new System.Drawing.Point(6, 109);
            this.CostLable.Name = "CostLable";
            this.CostLable.Size = new System.Drawing.Size(152, 28);
            this.CostLable.TabIndex = 12;
            this.CostLable.Text = "預估成本：";
            // 
            // EstimateCostLable
            // 
            this.EstimateCostLable.AutoSize = true;
            this.EstimateCostLable.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EstimateCostLable.Location = new System.Drawing.Point(150, 106);
            this.EstimateCostLable.Name = "EstimateCostLable";
            this.EstimateCostLable.Size = new System.Drawing.Size(25, 28);
            this.EstimateCostLable.TabIndex = 13;
            this.EstimateCostLable.Text = "0";
            // 
            // MaxShowhandBox
            // 
            this.MaxShowhandBox.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MaxShowhandBox.Location = new System.Drawing.Point(155, 142);
            this.MaxShowhandBox.Name = "MaxShowhandBox";
            this.MaxShowhandBox.Size = new System.Drawing.Size(194, 40);
            this.MaxShowhandBox.TabIndex = 14;
            this.MaxShowhandBox.TextChanged += new System.EventHandler(this.MaxShowhandBox_TextChanged);
            // 
            // SetPriceBox
            // 
            this.SetPriceBox.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SetPriceBox.Location = new System.Drawing.Point(414, 60);
            this.SetPriceBox.Name = "SetPriceBox";
            this.SetPriceBox.Size = new System.Drawing.Size(83, 40);
            this.SetPriceBox.TabIndex = 16;
            this.SetPriceBox.TextChanged += new System.EventHandler(this.SetPriceBox_TextChanged);
            // 
            // BuyButtom
            // 
            this.BuyButtom.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BuyButtom.Location = new System.Drawing.Point(383, 109);
            this.BuyButtom.Name = "BuyButtom";
            this.BuyButtom.Size = new System.Drawing.Size(117, 41);
            this.BuyButtom.TabIndex = 17;
            this.BuyButtom.Text = "買進";
            this.BuyButtom.UseVisualStyleBackColor = true;
            this.BuyButtom.Click += new System.EventHandler(this.BuyButtom_Click);
            // 
            // SellButtom
            // 
            this.SellButtom.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SellButtom.Location = new System.Drawing.Point(383, 156);
            this.SellButtom.Name = "SellButtom";
            this.SellButtom.Size = new System.Drawing.Size(117, 41);
            this.SellButtom.TabIndex = 18;
            this.SellButtom.Text = "賣出";
            this.SellButtom.UseVisualStyleBackColor = true;
            this.SellButtom.Click += new System.EventHandler(this.SellButtom_Click);
            // 
            // SetPriceLable
            // 
            this.SetPriceLable.AutoSize = true;
            this.SetPriceLable.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SetPriceLable.Location = new System.Drawing.Point(340, 65);
            this.SetPriceLable.Name = "SetPriceLable";
            this.SetPriceLable.Size = new System.Drawing.Size(68, 28);
            this.SetPriceLable.TabIndex = 19;
            this.SetPriceLable.Text = "價位";
            // 
            // NotGetLable
            // 
            this.NotGetLable.AutoSize = true;
            this.NotGetLable.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NotGetLable.Location = new System.Drawing.Point(196, 203);
            this.NotGetLable.Name = "NotGetLable";
            this.NotGetLable.Size = new System.Drawing.Size(25, 28);
            this.NotGetLable.TabIndex = 20;
            this.NotGetLable.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "未實現損益：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(66, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "總損益：";
            // 
            // GrossLable
            // 
            this.GrossLable.AutoSize = true;
            this.GrossLable.Font = new System.Drawing.Font("PMingLiU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GrossLable.Location = new System.Drawing.Point(196, 244);
            this.GrossLable.Name = "GrossLable";
            this.GrossLable.Size = new System.Drawing.Size(25, 28);
            this.GrossLable.TabIndex = 22;
            this.GrossLable.Text = "0";
            // 
            // Trading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GrossLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotGetLable);
            this.Controls.Add(this.SetPriceLable);
            this.Controls.Add(this.SellButtom);
            this.Controls.Add(this.BuyButtom);
            this.Controls.Add(this.SetPriceBox);
            this.Controls.Add(this.MaxShowhandBox);
            this.Controls.Add(this.EstimateCostLable);
            this.Controls.Add(this.CostLable);
            this.Controls.Add(this.CreatNumber);
            this.Controls.Add(this.MaxShowhandLable);
            this.Controls.Add(this.AccountName);
            this.Controls.Add(this.StockList);
            this.Controls.Add(this.TradeUnit);
            this.Controls.Add(this.AskGridView);
            this.Controls.Add(this.BidGridView);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.AccountLable);
            this.Controls.Add(this.MainerButton);
            this.Name = "Trading";
            this.Text = "Trading";
            ((System.ComponentModel.ISupportInitialize)(this.BidGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AskGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainerButton;
        private System.Windows.Forms.Label AccountLable;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.DataGridView BidGridView;
        private System.Windows.Forms.DataGridView AskGridView;
        private System.Windows.Forms.TextBox TradeUnit;
        private System.Windows.Forms.ComboBox StockList;
        private System.Windows.Forms.Label AccountName;
        private System.Windows.Forms.Label MaxShowhandLable;
        private System.Windows.Forms.Label CreatNumber;
        private System.Windows.Forms.Label CostLable;
        private System.Windows.Forms.Label EstimateCostLable;
        private System.Windows.Forms.TextBox MaxShowhandBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox SetPriceBox;
        private System.Windows.Forms.Button BuyButtom;
        private System.Windows.Forms.Button SellButtom;
        private System.Windows.Forms.Label SetPriceLable;
        private System.Windows.Forms.Label NotGetLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GrossLable;
    }
}