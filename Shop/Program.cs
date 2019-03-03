using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shops shop = new Shops();
            shop.ShopProducts();
            Person person = new Person("Иван", "Иванов", Pol.Man, Profession.Developer);
            Person person2 = new Person("Алексей", "Михайлов", Pol.Man, Profession.Mechanic);
            Console.WriteLine(person.id + " " + person.LastName + " " + person.profession + " " + person.pol);
            Console.WriteLine(person2.id + " " + person2.LastName + " " + person2.profession + " " + person2.pol);
            Buyer buyer2 = new Buyer();
            Buyer buyer = new Buyer(2000, "Алиса", "Виленова", Pol.Woman, Profession.Developer);
            Buyer buyer3 = new Buyer(1000, "Николай", "Валонук", Pol.Man, Profession.Cook);
            Buyer buyer4 = new Buyer(2000, "Виктор", "Налеканов", Pol.Man, Profession.Teacher);
            shop.SearchProducts(buyer.profession, buyer.Money);
            shop.SearchProducts(buyer3.profession, buyer3.Money);
            shop.SearchProducts(buyer4.profession, buyer4.Money);
            Console.ReadLine();
        }
    }
}
