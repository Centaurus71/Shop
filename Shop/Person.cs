using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    enum Profession
    {
        Student,
        Unemployed, //безработный
        Developer, //разработчик
        Teacher, //учитель
        Mechanic, //механик
        Cook, //повар
        Sportsman //спортсмен
    }

    class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pol { get; set; }
    }
}
