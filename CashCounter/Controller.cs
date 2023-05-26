using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashCounter
{
    internal class Controller
    {
        //Constructor that takes an initial list of products and adds them to the products list.
        public Controller( List<Product> initialProducts )
        {
            //Generate discountCode
            Random random = new Random();
            discountCode = random.Next( 1000, 10000 ).ToString();

            products.AddRange( initialProducts );
        }

        //Returns the products as formated data using a flag to detirmen what shold be added to output
        public string[] GetFormatedProducts( ProductFlags flags )
        {
            string[] data = new string[products.Count];

            int i = 0;
            foreach(Product product in products)
            {
                // Check if the "Name" flag is set in the provided flags.
                if(( ProductFlags.Name & flags ) != 0)
                {
                    if(!string.IsNullOrEmpty( data[i] ))
                        data[i] += " - ";
                    data[i] += product.name;
                }

                // Check if the "Code" flag is set in the provided flags.
                if(( ProductFlags.Code & flags ) != 0)
                {
                    if(!string.IsNullOrEmpty( data[i] ))
                        data[i] += " - ";
                    data[i] += product.code;
                }

                // Check if the "Amount" flag is set in the provided flags.
                if(( ProductFlags.Amount & flags ) != 0)
                {
                    if(!string.IsNullOrEmpty( data[i] ))
                        data[i] += " - ";
                    data[i] += product.amount;
                }

                // Check if the "SellPrice" flag is set in the provided flags.
                if(( ProductFlags.SellPrice & flags ) != 0)
                {
                    if(!string.IsNullOrEmpty( data[i] ))
                        data[i] += " - ";
                    data[i] += product.sellPrice;
                }

                // Check if the "BuyPrice" flag is set in the provided flags.
                if(( ProductFlags.BuyPrice & flags ) != 0)
                {
                    if(!string.IsNullOrEmpty( data[i] ))
                        data[i] += " - ";
                    data[i] += product.buyPrice;
                }

                // Check if the "Description" flag is set in the provided flags.
                if(( ProductFlags.Description & flags ) != 0)
                {
                    if(!string.IsNullOrEmpty( data[i] ))
                        data[i] += " - ";
                    data[i] += product.descriprion;
                }

                i++;
            }

            return data;
        }

        public string[] GetFormatedCart( ProductFlags flags )
        {
            string[] data = new string[cart.Count];

            int i = 0;
            foreach(Product product in cart)
            {
                // Check if the "Name" flag is set in the provided flags.
                if(( ProductFlags.Name & flags ) != 0)
                {
                    if(!string.IsNullOrEmpty( data[i] ))
                        data[i] += " - ";
                    data[i] += product.name;
                }

                // Check if the "Code" flag is set in the provided flags.
                if(( ProductFlags.Code & flags ) != 0)
                {
                    if(!string.IsNullOrEmpty( data[i] ))
                        data[i] += " - ";
                    data[i] += product.code;
                }

                // Check if the "Amount" flag is set in the provided flags.
                if(( ProductFlags.Amount & flags ) != 0)
                {
                    if(!string.IsNullOrEmpty( data[i] ))
                        data[i] += " - ";
                    data[i] += product.amount;
                }

                // Check if the "SellPrice" flag is set in the provided flags.
                if(( ProductFlags.SellPrice & flags ) != 0)
                {
                    if(!string.IsNullOrEmpty( data[i] ))
                        data[i] += " - ";
                    data[i] += product.sellPrice;
                }

                // Check if the "BuyPrice" flag is set in the provided flags.
                if(( ProductFlags.BuyPrice & flags ) != 0)
                {
                    if(!string.IsNullOrEmpty( data[i] ))
                        data[i] += " - ";
                    data[i] += product.buyPrice;
                }

                // Check if the "Description" flag is set in the provided flags.
                if(( ProductFlags.Description & flags ) != 0)
                {
                    if(!string.IsNullOrEmpty( data[i] ))
                        data[i] += " - ";
                    data[i] += product.descriprion;
                }

                i++;
            }

            return data;
        }

        public string[] GetFormatedHistory( ProductFlags flags )
        {
            string[] data = new string[history.Count];

            int i = 0;
            foreach(List<Product> purchases in history)
            {
                data[i] += "Order: " + ( i + 1 ).ToString() + "\r\n";

                foreach(Product product in purchases)
                {
                    // Check if the "Name" flag is set in the provided flags.
                    if(( ProductFlags.Name & flags ) != 0)
                    {
                        if(data[i][data[i].Length - 1] != '\n')
                            data[i] += " - ";
                        data[i] += product.name;
                    }

                    // Check if the "Code" flag is set in the provided flags.
                    if(( ProductFlags.Code & flags ) != 0)
                    {
                        if(data[i][data[i].Length - 1] != '\n')
                            data[i] += " - ";
                        data[i] += product.code;
                    }

                    // Check if the "Amount" flag is set in the provided flags.
                    if(( ProductFlags.Amount & flags ) != 0)
                    {
                        if(data[i][data[i].Length - 1] != '\n')
                            data[i] += " - ";
                        data[i] += product.amount;
                    }

                    // Check if the "SellPrice" flag is set in the provided flags.
                    if(( ProductFlags.SellPrice & flags ) != 0)
                    {
                        if(data[i][data[i].Length - 1] != '\n')
                            data[i] += " - ";
                        data[i] += product.sellPrice;
                    }

                    // Check if the "BuyPrice" flag is set in the provided flags.
                    if(( ProductFlags.BuyPrice & flags ) != 0)
                    {
                        if(data[i][data[i].Length - 1] != '\n')
                            data[i] += " - ";
                        data[i] += product.buyPrice;
                    }

                    // Check if the "Description" flag is set in the provided flags.
                    if(( ProductFlags.Description & flags ) != 0)
                    {
                        if(data[i][data[i].Length - 1] != '\n')
                            data[i] += " - ";
                        data[i] += product.descriprion;
                    }

                    data[i] += "\r\n";

                }

                i++;
            }

            return data;
        }


        public void AddProduct( Product product )
        {
            //Change Product Info if product already exist
            int existingProductIndex = products.FindIndex( p => p.code == product.code );
            if( existingProductIndex != -1 ) 
            {
                products[existingProductIndex] = product;
                return;
            }

            //Add new product
            products.Add(product);
        }

        public void RemoveProduct( Product product )
        {
            //Check if we have products in storage
            if(product.amount > 0)
            {
                //Ask user if they want to remove product 
                DialogResult res = MessageBox.Show( "Are you sure you want to remove product",
                    "Remove product", MessageBoxButtons.YesNo );

                if(res.Equals( DialogResult.Yes ))
                {
                    products.RemoveAll( p => product == p );
                }
            }
            else
            {
                products.RemoveAll( p => product == p );
            }
        }

        public int GetHistoryTotalPrice()
        {
            int price = 0;

            //Loop products and sum up price
            foreach(List<Product> purcheses in history)
            {
                foreach(Product product in purcheses)
                {
                    price += ( product.buyPrice * product.amount );
                }
            }

            return price;
        }

        public int GetHistoryTotalSellPrice()
        {
            int price = 0;

            //Loop products and sum up price
            foreach(List<Product> purcheses in history)
            {
                foreach(Product product in purcheses)
                {
                    price += ( product.sellPrice * product.amount );
                }
            }

            return price;
        }

        public void AddProductToCart( int index, int amount = 1 )
        {
            //Make sure we have enougth product in storage
            if(products[index].amount < amount)
            {
                MessageBox.Show( "Not enougth products in storage", "No products", MessageBoxButtons.OK );
                return;
            }

            //Temporary product
            Product prod = new Product( products[index] );
            prod.amount = amount;
            products[index].amount -= amount;

            //If product is not in cart
            if(cart.Find( p => p == prod ) == null)
            {
                cart.Add( prod );
                return;
            }

            //If product already exist in cart
            cart.Find( p => p == prod ).amount += prod.amount;
        }

        public void RemoveProductFromCart( int index, int amount = 1 )
        {
            //Make sure we don´t remove more from cart then exist
            amount = cart[index].amount < amount ? cart[index].amount : amount;

            //Add products back in storage
            products.Find( p => p == cart[index] ).amount += amount;

            //Remove amount from cart
            cart[index].amount -= amount;

            //Check if we empty all of product from cart
            if(cart[index].amount <= 0)
            {
                cart.RemoveAt( index );
            }
        }

        public int GetCartPrice()
        {
            int price = 0;

            //Loop products and sum up price
            foreach( Product product in cart ) 
            {
                price += ( product.sellPrice * product.amount );
            }

            return price;
        }

        public void BuyCart()
        {
            //Display Custom Messagebox
            TextInputMessageBox textBox = new TextInputMessageBox( "Do you have a discount code", "Discount" );
            textBox.ShowDialog();


            //Check if we have a discount
            float discount = 1.0f;
            if( textBox.output == discountCode )
            {
                discount = 0.85f;
            }
            else if( GetCartPrice() > 2000)
            {
                discount = 0.9f;
            }

            //Give discount to products
            foreach( Product product in cart )
            {
                product.sellPrice = (int)( product.sellPrice * discount );
            }

            //Add products to history and empty cart
            history.Add(new List<Product>(cart));
            cart.Clear();
        }

        //Discount code
        public string discountCode { get; }

        //List of products in storage
        public List<Product> products { get; } = new List<Product>();

        //List of products in cart
        public List<Product> cart { get; } = new List<Product>();

        //List of purcheses
        public List<List<Product>> history { get; } = new List<List<Product>>();
    }
}
