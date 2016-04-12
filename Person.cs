using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    public class Person
    {
        public List<Wallet> Wallets { get; set; }

        public PersonBalance Balance { get; set; }

        public Person()
        {
            Wallets = new List<Wallet>();
            Balance = new PersonBalance(this);
        }
    }
}
