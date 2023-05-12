using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashCounter
{
    public partial class Form1 : Form
    {
        Controller storeController = new Controller( new List<Product> {
            new Product("Cpu","cpu",10,2500,1500,"This is a very good cpu"),
            new Product("Monitor","mon",23,1000,600,"This is a cool monitor"),
        } );

        public Form1()
        {
            InitializeComponent();
            UpdateUI();
        }

        public void UpdateUI()
        {
            //Clear current Data
            lbxProductStorage.Items.Clear();
            lbxProductStorage.Items.Clear();
            lbxHistory.Items.Clear();

            //Add new data
            lbxProductShop.Items.AddRange( storeController.GetFormatedProducts() );
            lbxProductStorage.Items.AddRange( storeController.GetProductNames() );
        }

        private void btnAddProduct_Click( object sender, EventArgs e )
        {
            storeController.AddProduct( new Product( tbxProductName.Text, tbxProductCode.Text, int.Parse( tbxProductAmount.Text ),
                int.Parse( tbxProductSell.Text ), int.Parse( tbxProductBuy.Text ), tbxProductDescription.Text ) );

            UpdateUI();
        }
    }
}
