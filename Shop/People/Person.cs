using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    enum Profession
    {
        Developer, //разработчик
        Teacher, //учитель
        Mechanic, //механик
        Cook, //повар
        Sportsman //спортсмен
    }
    enum Pol
    {
        Man,
        Woman
    }

    class Person
    {
        static int numberPerson = 0;

        public int id { get;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Pol pol;
        public Profession profession;

        public Person()
        {
            id = numberPerson;
            numberPerson++;
        }
        public Person (string FirstName, string LastName, Pol pol, Profession profession)
        {
            id = numberPerson;
            numberPerson++;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.pol = pol;
            this.profession = profession;
        }
    }
}
