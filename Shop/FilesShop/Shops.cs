using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Shops : ISystemSearchcs
    {
        List<Product> products = new List<Product>();
        public void ShopProducts()
        {
            products.Add(new Product ("Мышка X7", 2500, Profession.Developer));
            products.Add(new Product("Клавиатура SVEN", 600, Profession.Developer));
            products.Add(new Product("Монитор LG", 15000, Profession.Developer));
            products.Add(new Product("Набор ручек",200 , Profession.Teacher));
            products.Add(new Product("Книга",1600 , Profession.Teacher));
            products.Add(new Product("Записная книжка", 600, Profession.Teacher));
            products.Add(new Product("Набор инструментов",5000 , Profession.Mechanic));
            products.Add(new Product("Перчатки",250 , Profession.Mechanic));
            products.Add(new Product("Средство для мытья рук от масляных загрязнений", 500, Profession.Mechanic));
            products.Add(new Product("Мясо", 400, Profession.Cook));
            products.Add(new Product("Овощи", 300, Profession.Cook));
            products.Add(new Product("Кухонные приборы", 2000, Profession.Cook));
        }
        public void SearchProducts(Profession profession, int Money)
        {
            Console.WriteLine("Обратите внимание на эти товары: ");
            foreach (Product qwe in products)
            {
                if (qwe.profession == profession & qwe.Price <= Money)
                {
                    Console.WriteLine(qwe.NameProduct + " " + qwe.Price);
                }
            }
        }
    }
}
