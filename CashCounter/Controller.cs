using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CashCounter
{
    internal class Controller
    {
        public Controller( List<Product> initialProducts )
        {
            products.AddRange( initialProducts );
        }

        public string[] GetFormatedProducts()
        {
            string[] data = new string[products.Count];

            int i = 0;
            foreach(Product product in products)
            {
                data[i++] = product.GetFormatedData();
            }

            return data;
        }

        public string[] GetProductNames()
        {
            string[] data = new string[products.Count];

            int i = 0;
            foreach(Product product in products)
            {
                data[i++] = product.name;
            }

            return data;
        }

        public void AddProduct( Product product )
        {
            //Change Product Info if product already exist
            int existingProductIndex = products.FindIndex( p => p.name == product.name );
            if(existingProductIndex != -1) 
            {
                products[existingProductIndex] = product;
                return;
            }

            //Add new product
            products.Add(product);
        }

        public List<Product> products { get; } = new List<Product>();
    }
}
