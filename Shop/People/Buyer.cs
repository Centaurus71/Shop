using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Buyer : Person, IPurse
    {
        public int Money { get; set; }

        public Buyer() { }
        public Buyer(int Money, string FirstName, string LastName, Pol pol, Profession profession)
            : base (FirstName, LastName, pol, profession)
        {
            this.Money = Money;
        }

        public int Sum
        {
            get { return Money; }
            set { value = Money; }
        }
        public void AddMoney (int Money)
        {
            Sum += Money;
        }
        public int DecMoney (int Money)
        {
            if (Sum > Money)
            {
                Sum -= Money;
            }
            return Sum;
        }
    }
}
