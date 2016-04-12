using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    public abstract class Card
    {
        public CardBalance Balance { get; set; }
    }

    public class Visa : Card
    {
        public Visa(double loanBalance)
        {
            this.Balance = new CardBalance
            {
                InterestRate = 10.0,
                LoanBalance = loanBalance
            };
        }
    }

    public class Master : Card
    {
        public Master(double loanBalance)
        {
            this.Balance = new CardBalance
            {
                InterestRate = 5.0,
                LoanBalance = loanBalance
            };
        }
    }

    public class Discover : Card
    {
        public Discover(double loanBalance)
        {
            this.Balance = new CardBalance
            {
                InterestRate = 1.0,
                LoanBalance = loanBalance
            };
        }
    }
}
