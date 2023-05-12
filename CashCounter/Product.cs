using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCounter
{
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

        public Product(string name, string code, int amount, int sellPrice, int buyPrice, string descriprion )
        {
            this.name = name;
            this.code = code;
            this.amount = amount;
            this.sellPrice = sellPrice;
            this.buyPrice = buyPrice;
            this.descriprion = descriprion;
        }

        public string GetFormatedData()
        {
            return name + " - " + amount + " - " + sellPrice + "kr";
        }

        //Product Data
        public string name { get; }
        public string code { get; }
        public int amount { get; }
        public int sellPrice { get;  }
        public int buyPrice { get; }
        public string descriprion { get; }
    }
}
