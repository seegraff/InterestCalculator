using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    public class Wallet
    {
        public List<Card> Cards { get; set; }

        public WalletBalance Balance { get; set; }

        public Wallet()
        {
            Cards = new List<Card>();
            Balance = new WalletBalance(this);
        }
    }
}
