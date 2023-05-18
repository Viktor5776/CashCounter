using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCounter
{
    [Flags]
    public enum ProductFlags
    {
        None = 0,
        Name = 1,
        Code = 2,
        Amount = 4,
        SellPrice = 8,
        BuyPrice = 16,
        Description = 32,
    }

    internal class Product
    {
        public Product()
        {
            name = "";
            code = "";
            amount = 0;
            sellPrice = 0;
            buyPrice = 0;
            descriprion = "";
        }

        public Product( Product p )
        {
            name = p.name;
            code = p.code;
            amount = p.amount;
            sellPrice = p.sellPrice;
            buyPrice = p.buyPrice;
            descriprion = p.descriprion;
        }

        public Product(string name, string code, int amount, int sellPrice, int buyPrice, string descriprion )
        {
            this.name = name;
            this.code = code;
            this.amount = amount;
            this.sellPrice = sellPrice;
            this.buyPrice = buyPrice;
            this.descriprion = descriprion;
        }


        public static bool operator==(Product lhs, Product rhs)
        {
            if(ReferenceEquals( lhs, rhs )) return true;

            if(ReferenceEquals( lhs, null ) || ReferenceEquals( rhs, null )) return false;

            return lhs.code == rhs.code;
        }

        public static bool operator !=( Product lhs, Product rhs )
        {
            return lhs.code != rhs.code;
        }

        //Product Data
        public string name { get; }
        public string code { get; }
        public int amount { get; set; }
        public int sellPrice { get;  }
        public int buyPrice { get; }
        public string descriprion { get; }
    }
}
