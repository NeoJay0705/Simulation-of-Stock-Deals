namespace LoginForm
{
    partial class PersonalAccount
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AccountGridView = new System.Windows.Forms.DataGridView();
            this.StockNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockAffordPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockTotalUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockAverageCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockThisProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RenewAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountGridView
            // 
            this.AccountGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.AccountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockNumber,
            this.StockName,
            this.StockAffordPrice,
            this.StockTotalUnit,
            this.StockAverageCost,
            this.StockThisProfit});
            this.AccountGridView.Location = new System.Drawing.Point(12, 51);
            this.AccountGridView.Name = "AccountGridView";
            this.AccountGridView.RowTemplate.Height = 27;
            this.AccountGridView.Size = new System.Drawing.Size(754, 189);
            this.AccountGridView.TabIndex = 0;
            this.AccountGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StockNumber
            // 
            this.StockNumber.HeaderText = "代號";
            this.StockNumber.Name = "StockNumber";
            this.StockNumber.ReadOnly = true;
            // 
            // StockName
            // 
            this.StockName.HeaderText = "名稱";
            this.StockName.Name = "StockName";
            this.StockName.ReadOnly = true;
            // 
            // StockAffordPrice
            // 
            this.StockAffordPrice.HeaderText = "成交價";
            this.StockAffordPrice.Name = "StockAffordPrice";
            this.StockAffordPrice.ReadOnly = true;
            // 
            // StockTotalUnit
            // 
            this.StockTotalUnit.HeaderText = "口數";
            this.StockTotalUnit.Name = "StockTotalUnit";
            this.StockTotalUnit.ReadOnly = true;
            // 
            // StockAverageCost
            // 
            this.StockAverageCost.HeaderText = "平均成本";
            this.StockAverageCost.Name = "StockAverageCost";
            this.StockAverageCost.ReadOnly = true;
            this.StockAverageCost.Width = 200;
            // 
            // StockThisProfit
            // 
            this.StockThisProfit.HeaderText = "損益";
            this.StockThisProfit.Name = "StockThisProfit";
            this.StockThisProfit.ReadOnly = true;
            // 
            // stockAccountBindingSource
            // 
            this.stockAccountBindingSource.DataSource = typeof(PersonalLibrary.StockAccount);
            // 
            // RenewAccount
            // 
            this.RenewAccount.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RenewAccount.Location = new System.Drawing.Point(13, 13);
            this.RenewAccount.Name = "RenewAccount";
            this.RenewAccount.Size = new System.Drawing.Size(124, 32);
            this.RenewAccount.TabIndex = 1;
            this.RenewAccount.Text = "重新整理";
            this.RenewAccount.UseVisualStyleBackColor = true;
            this.RenewAccount.Click += new System.EventHandler(this.RenewAccount_Click);
            // 
            // PersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 258);
            this.Controls.Add(this.RenewAccount);
            this.Controls.Add(this.AccountGridView);
            this.Name = "PersonalAccount";
            this.Text = "帳目查詢";
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockAccountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountGridView;
        private System.Windows.Forms.BindingSource stockAccountBindingSource;
        private System.Windows.Forms.Button RenewAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockAffordPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockTotalUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockAverageCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockThisProfit;
    }
}