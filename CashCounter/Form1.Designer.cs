namespace CashCounter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if(disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcnMain = new System.Windows.Forms.TabControl();
            this.tpgCash = new System.Windows.Forms.TabPage();
            this.btnOut = new System.Windows.Forms.Button();
            this.lblShoppingCart = new System.Windows.Forms.Label();
            this.lblProductList = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblPay = new System.Windows.Forms.Label();
            this.lbxCart = new System.Windows.Forms.ListBox();
            this.lbxProductShop = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tpgHistory = new System.Windows.Forms.TabPage();
            this.lblHistory = new System.Windows.Forms.Label();
            this.lbxHistory = new System.Windows.Forms.ListBox();
            this.lblShopHistory = new System.Windows.Forms.Label();
            this.tpgStorage = new System.Windows.Forms.TabPage();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.tbxProductBuy = new System.Windows.Forms.TextBox();
            this.tbxProductSell = new System.Windows.Forms.TextBox();
            this.tbxProductAmount = new System.Windows.Forms.TextBox();
            this.tbxProductCode = new System.Windows.Forms.TextBox();
            this.tbxProductDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxProductStorage = new System.Windows.Forms.ListBox();
            this.tcnMain.SuspendLayout();
            this.tpgCash.SuspendLayout();
            this.tpgHistory.SuspendLayout();
            this.tpgStorage.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcnMain
            // 
            this.tcnMain.Controls.Add(this.tpgCash);
            this.tcnMain.Controls.Add(this.tpgHistory);
            this.tcnMain.Controls.Add(this.tpgStorage);
            this.tcnMain.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcnMain.Location = new System.Drawing.Point(10, 11);
            this.tcnMain.Margin = new System.Windows.Forms.Padding(2);
            this.tcnMain.Name = "tcnMain";
            this.tcnMain.SelectedIndex = 0;
            this.tcnMain.Size = new System.Drawing.Size(581, 345);
            this.tcnMain.TabIndex = 1;
            // 
            // tpgCash
            // 
            this.tpgCash.Controls.Add(this.btnOut);
            this.tpgCash.Controls.Add(this.lblShoppingCart);
            this.tpgCash.Controls.Add(this.lblProductList);
            this.tpgCash.Controls.Add(this.btnIn);
            this.tpgCash.Controls.Add(this.btnBuy);
            this.tpgCash.Controls.Add(this.lblPay);
            this.tpgCash.Controls.Add(this.lbxCart);
            this.tpgCash.Controls.Add(this.lbxProductShop);
            this.tpgCash.Controls.Add(this.lblTitle);
            this.tpgCash.Location = new System.Drawing.Point(4, 22);
            this.tpgCash.Margin = new System.Windows.Forms.Padding(2);
            this.tpgCash.Name = "tpgCash";
            this.tpgCash.Padding = new System.Windows.Forms.Padding(2);
            this.tpgCash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpgCash.Size = new System.Drawing.Size(573, 319);
            this.tpgCash.TabIndex = 0;
            this.tpgCash.Text = "Cash Counter";
            this.tpgCash.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(247, 169);
            this.btnOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(69, 31);
            this.btnOut.TabIndex = 7;
            this.btnOut.Text = "<----";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.Location = new System.Drawing.Point(370, 84);
            this.lblShoppingCart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(75, 14);
            this.lblShoppingCart.TabIndex = 6;
            this.lblShoppingCart.Text = "Shopping Cart";
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Location = new System.Drawing.Point(44, 84);
            this.lblProductList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(64, 14);
            this.lblProductList.TabIndex = 5;
            this.lblProductList.Text = "Product List";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(247, 133);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(69, 31);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "---->";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(386, 278);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(146, 31);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // lblPay
            // 
            this.lblPay.BackColor = System.Drawing.Color.IndianRed;
            this.lblPay.Location = new System.Drawing.Point(370, 254);
            this.lblPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(162, 22);
            this.lblPay.TabIndex = 2;
            this.lblPay.Text = "Amout to pay 0";
            this.lblPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxCart
            // 
            this.lbxCart.FormattingEnabled = true;
            this.lbxCart.Location = new System.Drawing.Point(370, 102);
            this.lbxCart.Margin = new System.Windows.Forms.Padding(2);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(163, 147);
            this.lbxCart.TabIndex = 1;
            // 
            // lbxProductShop
            // 
            this.lbxProductShop.FormattingEnabled = true;
            this.lbxProductShop.Location = new System.Drawing.Point(44, 102);
            this.lbxProductShop.Margin = new System.Windows.Forms.Padding(2);
            this.lbxProductShop.Name = "lbxProductShop";
            this.lbxProductShop.Size = new System.Drawing.Size(163, 147);
            this.lbxProductShop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(187, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cash Counter";
            // 
            // tpgHistory
            // 
            this.tpgHistory.Controls.Add(this.lblHistory);
            this.tpgHistory.Controls.Add(this.lbxHistory);
            this.tpgHistory.Controls.Add(this.lblShopHistory);
            this.tpgHistory.Location = new System.Drawing.Point(4, 22);
            this.tpgHistory.Margin = new System.Windows.Forms.Padding(2);
            this.tpgHistory.Name = "tpgHistory";
            this.tpgHistory.Padding = new System.Windows.Forms.Padding(2);
            this.tpgHistory.Size = new System.Drawing.Size(573, 319);
            this.tpgHistory.TabIndex = 1;
            this.tpgHistory.Text = "History";
            this.tpgHistory.UseVisualStyleBackColor = true;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(57, 72);
            this.lblHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(58, 20);
            this.lblHistory.TabIndex = 2;
            this.lblHistory.Text = "History";
            // 
            // lbxHistory
            // 
            this.lbxHistory.FormattingEnabled = true;
            this.lbxHistory.Location = new System.Drawing.Point(52, 95);
            this.lbxHistory.Margin = new System.Windows.Forms.Padding(2);
            this.lbxHistory.Name = "lbxHistory";
            this.lbxHistory.Size = new System.Drawing.Size(482, 212);
            this.lbxHistory.TabIndex = 1;
            // 
            // lblShopHistory
            // 
            this.lblShopHistory.AutoSize = true;
            this.lblShopHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopHistory.Location = new System.Drawing.Point(222, 55);
            this.lblShopHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShopHistory.Name = "lblShopHistory";
            this.lblShopHistory.Size = new System.Drawing.Size(137, 26);
            this.lblShopHistory.TabIndex = 0;
            this.lblShopHistory.Text = "Shop History";
            // 
            // tpgStorage
            // 
            this.tpgStorage.Controls.Add(this.gbxProduct);
            this.tpgStorage.Controls.Add(this.label1);
            this.tpgStorage.Controls.Add(this.lbxProductStorage);
            this.tpgStorage.Location = new System.Drawing.Point(4, 22);
            this.tpgStorage.Margin = new System.Windows.Forms.Padding(2);
            this.tpgStorage.Name = "tpgStorage";
            this.tpgStorage.Padding = new System.Windows.Forms.Padding(2);
            this.tpgStorage.Size = new System.Drawing.Size(573, 319);
            this.tpgStorage.TabIndex = 2;
            this.tpgStorage.Text = "Storage";
            this.tpgStorage.UseVisualStyleBackColor = true;
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.tbxProductBuy);
            this.gbxProduct.Controls.Add(this.tbxProductSell);
            this.gbxProduct.Controls.Add(this.tbxProductAmount);
            this.gbxProduct.Controls.Add(this.tbxProductCode);
            this.gbxProduct.Controls.Add(this.tbxProductDescription);
            this.gbxProduct.Controls.Add(this.lblDescription);
            this.gbxProduct.Controls.Add(this.lblBuyPrice);
            this.gbxProduct.Controls.Add(this.lblSellPrice);
            this.gbxProduct.Controls.Add(this.lblAmount);
            this.gbxProduct.Controls.Add(this.lblCode);
            this.gbxProduct.Controls.Add(this.lblName);
            this.gbxProduct.Controls.Add(this.tbxProductName);
            this.gbxProduct.Controls.Add(this.btnAddProduct);
            this.gbxProduct.Controls.Add(this.btnRemoveProduct);
            this.gbxProduct.Location = new System.Drawing.Point(354, 39);
            this.gbxProduct.Margin = new System.Windows.Forms.Padding(2);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Padding = new System.Windows.Forms.Padding(2);
            this.gbxProduct.Size = new System.Drawing.Size(190, 254);
            this.gbxProduct.TabIndex = 8;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Product";
            // 
            // tbxProductBuy
            // 
            this.tbxProductBuy.Location = new System.Drawing.Point(54, 125);
            this.tbxProductBuy.Margin = new System.Windows.Forms.Padding(2);
            this.tbxProductBuy.Name = "tbxProductBuy";
            this.tbxProductBuy.Size = new System.Drawing.Size(132, 19);
            this.tbxProductBuy.TabIndex = 5;
            // 
            // tbxProductSell
            // 
            this.tbxProductSell.Location = new System.Drawing.Point(54, 102);
            this.tbxProductSell.Margin = new System.Windows.Forms.Padding(2);
            this.tbxProductSell.Name = "tbxProductSell";
            this.tbxProductSell.Size = new System.Drawing.Size(132, 19);
            this.tbxProductSell.TabIndex = 4;
            // 
            // tbxProductAmount
            // 
            this.tbxProductAmount.Location = new System.Drawing.Point(48, 80);
            this.tbxProductAmount.Margin = new System.Windows.Forms.Padding(2);
            this.tbxProductAmount.Name = "tbxProductAmount";
            this.tbxProductAmount.Size = new System.Drawing.Size(138, 19);
            this.tbxProductAmount.TabIndex = 3;
            // 
            // tbxProductCode
            // 
            this.tbxProductCode.Location = new System.Drawing.Point(40, 56);
            this.tbxProductCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbxProductCode.MaxLength = 3;
            this.tbxProductCode.Name = "tbxProductCode";
            this.tbxProductCode.Size = new System.Drawing.Size(146, 19);
            this.tbxProductCode.TabIndex = 2;
            // 
            // tbxProductDescription
            // 
            this.tbxProductDescription.Location = new System.Drawing.Point(4, 171);
            this.tbxProductDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbxProductDescription.Multiline = true;
            this.tbxProductDescription.Name = "tbxProductDescription";
            this.tbxProductDescription.Size = new System.Drawing.Size(182, 44);
            this.tbxProductDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(4, 155);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(61, 14);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.Location = new System.Drawing.Point(4, 130);
            this.lblBuyPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(53, 14);
            this.lblBuyPrice.TabIndex = 7;
            this.lblBuyPrice.Text = "Buy Price";
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Location = new System.Drawing.Point(2, 107);
            this.lblSellPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(51, 14);
            this.lblSellPrice.TabIndex = 6;
            this.lblSellPrice.Text = "Sell Price";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(4, 82);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(44, 14);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(2, 58);
            this.lblCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 14);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Code";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(2, 32);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 14);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(40, 29);
            this.tbxProductName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(146, 19);
            this.tbxProductName.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(4, 219);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(85, 30);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(100, 219);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(85, 30);
            this.btnRemoveProduct.TabIndex = 8;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product List";
            // 
            // lbxProductStorage
            // 
            this.lbxProductStorage.FormattingEnabled = true;
            this.lbxProductStorage.Location = new System.Drawing.Point(34, 57);
            this.lbxProductStorage.Margin = new System.Windows.Forms.Padding(2);
            this.lbxProductStorage.Name = "lbxProductStorage";
            this.lbxProductStorage.Size = new System.Drawing.Size(163, 238);
            this.lbxProductStorage.TabIndex = 6;
            this.lbxProductStorage.SelectedIndexChanged += new System.EventHandler(this.lbxProductStorage_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tcnMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "CashCounter";
            this.tcnMain.ResumeLayout(false);
            this.tpgCash.ResumeLayout(false);
            this.tpgCash.PerformLayout();
            this.tpgHistory.ResumeLayout(false);
            this.tpgHistory.PerformLayout();
            this.tpgStorage.ResumeLayout(false);
            this.tpgStorage.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcnMain;
        private System.Windows.Forms.TabPage tpgCash;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lblShoppingCart;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.ListBox lbxCart;
        private System.Windows.Forms.ListBox lbxProductShop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tpgHistory;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.ListBox lbxHistory;
        private System.Windows.Forms.Label lblShopHistory;
        private System.Windows.Forms.TabPage tpgStorage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxProductStorage;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.TextBox tbxProductBuy;
        private System.Windows.Forms.TextBox tbxProductSell;
        private System.Windows.Forms.TextBox tbxProductAmount;
        private System.Windows.Forms.TextBox tbxProductCode;
        private System.Windows.Forms.TextBox tbxProductDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBuyPrice;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
    }
}

