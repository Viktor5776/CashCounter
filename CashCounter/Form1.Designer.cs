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
            this.tcnMain.Location = new System.Drawing.Point(13, 13);
            this.tcnMain.Name = "tcnMain";
            this.tcnMain.SelectedIndex = 0;
            this.tcnMain.Size = new System.Drawing.Size(775, 425);
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
            this.tpgCash.Location = new System.Drawing.Point(4, 25);
            this.tpgCash.Name = "tpgCash";
            this.tpgCash.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpgCash.Size = new System.Drawing.Size(767, 396);
            this.tpgCash.TabIndex = 0;
            this.tpgCash.Text = "Cash Counter";
            this.tpgCash.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(329, 208);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(92, 38);
            this.btnOut.TabIndex = 7;
            this.btnOut.Text = "<----";
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.Location = new System.Drawing.Point(493, 103);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(89, 16);
            this.lblShoppingCart.TabIndex = 6;
            this.lblShoppingCart.Text = "Shopping Cart";
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Location = new System.Drawing.Point(58, 103);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(77, 16);
            this.lblProductList.TabIndex = 5;
            this.lblProductList.Text = "Product List";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(329, 164);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(92, 38);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "---->";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(514, 342);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(195, 38);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // lblPay
            // 
            this.lblPay.BackColor = System.Drawing.Color.IndianRed;
            this.lblPay.Location = new System.Drawing.Point(493, 312);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(216, 27);
            this.lblPay.TabIndex = 2;
            this.lblPay.Text = "Amout to pay 0";
            this.lblPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxCart
            // 
            this.lbxCart.FormattingEnabled = true;
            this.lbxCart.ItemHeight = 16;
            this.lbxCart.Location = new System.Drawing.Point(493, 125);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(216, 180);
            this.lbxCart.TabIndex = 1;
            // 
            // lbxProductShop
            // 
            this.lbxProductShop.FormattingEnabled = true;
            this.lbxProductShop.ItemHeight = 16;
            this.lbxProductShop.Location = new System.Drawing.Point(58, 125);
            this.lbxProductShop.Name = "lbxProductShop";
            this.lbxProductShop.Size = new System.Drawing.Size(216, 180);
            this.lbxProductShop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(249, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cash Counter";
            // 
            // tpgHistory
            // 
            this.tpgHistory.Controls.Add(this.lblHistory);
            this.tpgHistory.Controls.Add(this.lbxHistory);
            this.tpgHistory.Controls.Add(this.lblShopHistory);
            this.tpgHistory.Location = new System.Drawing.Point(4, 25);
            this.tpgHistory.Name = "tpgHistory";
            this.tpgHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tpgHistory.Size = new System.Drawing.Size(767, 396);
            this.tpgHistory.TabIndex = 1;
            this.tpgHistory.Text = "History";
            this.tpgHistory.UseVisualStyleBackColor = true;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(76, 89);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(72, 25);
            this.lblHistory.TabIndex = 2;
            this.lblHistory.Text = "History";
            // 
            // lbxHistory
            // 
            this.lbxHistory.FormattingEnabled = true;
            this.lbxHistory.ItemHeight = 16;
            this.lbxHistory.Location = new System.Drawing.Point(70, 117);
            this.lbxHistory.Name = "lbxHistory";
            this.lbxHistory.Size = new System.Drawing.Size(641, 260);
            this.lbxHistory.TabIndex = 1;
            // 
            // lblShopHistory
            // 
            this.lblShopHistory.AutoSize = true;
            this.lblShopHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopHistory.Location = new System.Drawing.Point(296, 68);
            this.lblShopHistory.Name = "lblShopHistory";
            this.lblShopHistory.Size = new System.Drawing.Size(176, 32);
            this.lblShopHistory.TabIndex = 0;
            this.lblShopHistory.Text = "Shop History";
            // 
            // tpgStorage
            // 
            this.tpgStorage.Controls.Add(this.gbxProduct);
            this.tpgStorage.Controls.Add(this.label1);
            this.tpgStorage.Controls.Add(this.lbxProductStorage);
            this.tpgStorage.Location = new System.Drawing.Point(4, 25);
            this.tpgStorage.Name = "tpgStorage";
            this.tpgStorage.Padding = new System.Windows.Forms.Padding(3);
            this.tpgStorage.Size = new System.Drawing.Size(767, 396);
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
            this.gbxProduct.Location = new System.Drawing.Point(472, 48);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(253, 312);
            this.gbxProduct.TabIndex = 8;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Product";
            // 
            // tbxProductBuy
            // 
            this.tbxProductBuy.Location = new System.Drawing.Point(72, 154);
            this.tbxProductBuy.Name = "tbxProductBuy";
            this.tbxProductBuy.Size = new System.Drawing.Size(175, 22);
            this.tbxProductBuy.TabIndex = 13;
            // 
            // tbxProductSell
            // 
            this.tbxProductSell.Location = new System.Drawing.Point(72, 126);
            this.tbxProductSell.Name = "tbxProductSell";
            this.tbxProductSell.Size = new System.Drawing.Size(175, 22);
            this.tbxProductSell.TabIndex = 12;
            // 
            // tbxProductAmount
            // 
            this.tbxProductAmount.Location = new System.Drawing.Point(64, 98);
            this.tbxProductAmount.Name = "tbxProductAmount";
            this.tbxProductAmount.Size = new System.Drawing.Size(183, 22);
            this.tbxProductAmount.TabIndex = 11;
            // 
            // tbxProductCode
            // 
            this.tbxProductCode.Location = new System.Drawing.Point(53, 69);
            this.tbxProductCode.MaxLength = 3;
            this.tbxProductCode.Name = "tbxProductCode";
            this.tbxProductCode.Size = new System.Drawing.Size(194, 22);
            this.tbxProductCode.TabIndex = 10;
            // 
            // tbxProductDescription
            // 
            this.tbxProductDescription.Location = new System.Drawing.Point(6, 210);
            this.tbxProductDescription.Multiline = true;
            this.tbxProductDescription.Name = "tbxProductDescription";
            this.tbxProductDescription.Size = new System.Drawing.Size(241, 53);
            this.tbxProductDescription.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 191);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 16);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.Location = new System.Drawing.Point(6, 160);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(64, 16);
            this.lblBuyPrice.TabIndex = 7;
            this.lblBuyPrice.Text = "Buy Price";
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Location = new System.Drawing.Point(3, 132);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(63, 16);
            this.lblSellPrice.TabIndex = 6;
            this.lblSellPrice.Text = "Sell Price";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(6, 101);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 16);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(3, 72);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(37, 16);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Code";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(53, 36);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(194, 22);
            this.tbxProductName.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(6, 269);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(113, 37);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(134, 269);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(113, 37);
            this.btnRemoveProduct.TabIndex = 0;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product List";
            // 
            // lbxProductStorage
            // 
            this.lbxProductStorage.FormattingEnabled = true;
            this.lbxProductStorage.ItemHeight = 16;
            this.lbxProductStorage.Location = new System.Drawing.Point(46, 70);
            this.lbxProductStorage.Name = "lbxProductStorage";
            this.lbxProductStorage.Size = new System.Drawing.Size(216, 292);
            this.lbxProductStorage.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcnMain);
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

