using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Product
    {
        static int numberProduct = 0;

        public int idproduct { get; }
        public string NameProduct {get; set;}
        public int Price { get; set; }
        public Profession profession;

        public Product() { idproduct = numberProduct; numberProduct++;}

        public Product(string NameProduct, int Price, Profession profession)
        {
            idproduct = numberProduct;
            numberProduct++;
            this.NameProduct = NameProduct;
            this.Price = Price;
            this.profession = profession;
        }
    }
}
