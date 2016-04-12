using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    public interface IBalance
    {
        double CompoundBalance { get; set; }

        double LoanBalance { get; set; }

        double TotalBalance { get; }

        void Calculate();
    }

    public abstract class Balance : IBalance
    {
        public double CompoundBalance { get; set; }

        public double LoanBalance { get; set; }

        public double TotalBalance
        {
            get
            {
                return LoanBalance + CompoundBalance;
            }
        }

        public abstract void Calculate();

        public abstract void Display();
    }

    public class CardBalance : Balance
    {
        public double InterestRate { get; set; }

        public override void Calculate()
        {
            CompoundBalance += TotalBalance * (InterestRate / 100);
        }

        public override void Display()
        {
            Console.WriteLine("Card's Loan Balance: " + LoanBalance);
            Console.WriteLine("Card's Compound Balance: " + CompoundBalance);
            Console.WriteLine("Card's Total Balance: " + TotalBalance);
            Console.WriteLine();
        }
    }

    public class WalletBalance : Balance
    {
        public Wallet Wallet { get; set; }

        public WalletBalance(Wallet Wallet)
        {
            this.Wallet = Wallet;
        }

        public override void Calculate()
        {
            foreach(Card Card in Wallet.Cards)
            {
                Card.Balance.Calculate();
                CompoundBalance += Card.Balance.CompoundBalance;
                LoanBalance += Card.Balance.LoanBalance;
            }
        }

        public override void Display()
        {
            Console.WriteLine("Wallet's Loan Balance: " + LoanBalance);
            Console.WriteLine("Wallet's Compound Balance: " + CompoundBalance);
            Console.WriteLine("Wallet's Total Balance: " + TotalBalance);
            Console.WriteLine();

            foreach(Card Card in Wallet.Cards)
            {
                Card.Balance.Display();
            }
        }
    }

    public class PersonBalance : Balance
    {
        public Person Person { get; set; }

        public PersonBalance(Person Person)
        {
            this.Person = Person;
        }

        public override void Calculate()
        {
            foreach(Wallet Wallet in Person.Wallets)
            {
                Wallet.Balance.Calculate();
                CompoundBalance += Wallet.Balance.CompoundBalance;
                LoanBalance += Wallet.Balance.LoanBalance;
            }
        }

        public override void Display()
        {
            Console.WriteLine("Person's Loan Balance: " + LoanBalance);
            Console.WriteLine("Person's Compound Balance: " + CompoundBalance);
            Console.WriteLine("Person's Total Balance: " + TotalBalance);
            Console.WriteLine();

            foreach(Wallet Wallet in Person.Wallets)
            {
                Wallet.Balance.Display();
            }
        }
    }
}
