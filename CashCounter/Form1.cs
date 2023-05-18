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

        //Update all UI Elements on form
        void UpdateUI()
        {
            //Clear current Data
            lbxProductStorage.Items.Clear();
            lbxProductShop.Items.Clear();
            lbxHistory.Items.Clear();
            lbxCart.Items.Clear();

            //Add new data
            lbxProductShop.Items.AddRange( storeController.GetFormatedProducts( ProductFlags.Name | ProductFlags.Amount | ProductFlags.SellPrice ) );
            lbxProductStorage.Items.AddRange( storeController.GetFormatedProducts( ProductFlags.Name | ProductFlags.Code ) );
            lbxCart.Items.AddRange( storeController.GetFormatedCart( ProductFlags.Name | ProductFlags.Amount | ProductFlags.SellPrice ) );

            lblPay.Text = "Amout to pay " + storeController.GetCartPrice();

        }

        Tuple<bool, Product> GetSelectedProduct()
        {
            return new Tuple<bool, Product>( 
                
            //Check if we have enterd all information
            string.IsNullOrEmpty( tbxProductName.Text ) &&
            string.IsNullOrEmpty( tbxProductCode.Text ) &&
            string.IsNullOrEmpty( tbxProductAmount.Text ) &&
            string.IsNullOrEmpty( tbxProductSell.Text ) &&
            string.IsNullOrEmpty( tbxProductBuy.Text ) &&
            string.IsNullOrEmpty( tbxProductDescription.Text ),     
                
            //Save Infromation in product
            new Product(
                tbxProductName.Text,
                tbxProductCode.Text,
                parseNumber( tbxProductAmount.Text ),
                parseNumber( tbxProductSell.Text ),
                parseNumber( tbxProductBuy.Text ),
                tbxProductDescription.Text ) );
        }

        //Safe input for numbers
        int parseNumber( string num )
        {
            if( int.TryParse( num, out int result ) )
            {
                return result >= 0 ? result : 0;
            }

            return 0;
        }

        private void btnAddProduct_Click( object sender, EventArgs e )
        {
            Tuple<bool, Product> product = GetSelectedProduct();

            //Check if input fields are filled
            if(!product.Item1)
                MessageBox.Show( "Enter all input fields", "Enter fields" );
            
            //Add product and update UI
            storeController.AddProduct( product.Item2 );
            UpdateUI();
        }

        private void btnRemoveProduct_Click( object sender, EventArgs e )
        {
            Tuple<bool, Product> product = GetSelectedProduct();

            //Check if input fields are filled
            if(!product.Item1)
                MessageBox.Show( "Enter all input fields", "Enter fields" );

            //Remove product and update UI
            storeController.RemoveProduct( product.Item2 );
            UpdateUI();
        }

        private void lbxProductStorage_SelectedIndexChanged( object sender, EventArgs e )
        {
            //Make sure we have selected product
            if(lbxProductStorage.SelectedIndex == -1 ) { return; }

            //Get selected product
            Product product = storeController.products[lbxProductStorage.SelectedIndex];

            //Save product data in input
            tbxProductName.Text = product.name;
            tbxProductCode.Text = product.code;
            tbxProductAmount.Text = product.amount.ToString();
            tbxProductSell.Text = product.sellPrice.ToString();
            tbxProductBuy.Text = product.buyPrice.ToString();
            tbxProductDescription.Text = product.descriprion;
        }

        private void btnIn_Click( object sender, EventArgs e )
        {
            //Make sure we have selected a product
            if( lbxProductShop.SelectedIndex == -1 ) { return; }

            //Add product to cart and update UI
            storeController.AddProductToCart( lbxProductShop.SelectedIndex );
            UpdateUI();
        }

        private void btnOut_Click( object sender, EventArgs e )
        {
            //Make sure we have selected a product
            if( lbxCart.SelectedIndex == -1 ) { return; }

            //Remove product from cart and update UI
            storeController.RemoveProductFromCart( lbxCart.SelectedIndex );
            UpdateUI();
        }
    }
}
