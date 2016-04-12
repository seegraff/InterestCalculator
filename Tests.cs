using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace InterestCalculator
{
    [TestFixture]
    public class FirstWallet
    {
        public Person Joe;

        [SetUp]
        public void Init()
        {
            Card JoesVisa = new Visa(100);
            Card JoesMaster = new Master(100);
            Card JoesDiscover = new Discover(100);

            Wallet JoesFirstWallet = new Wallet();

            JoesFirstWallet.Cards.Add(JoesVisa);
            JoesFirstWallet.Cards.Add(JoesMaster);
            JoesFirstWallet.Cards.Add(JoesDiscover);

            Joe = new Person();

            Joe.Wallets.Add(JoesFirstWallet);

            Joe.Balance.Calculate();
        }

        [Test]
        public void DisplayFirst()
        {
            Joe.Balance.Display();
        }
    }

    [TestFixture]
    public class SecondWallet
    {
        public Person John;

        [SetUp]
        public void Init()
        {
            Card JohnsVisa = new Visa(100);
            Card JohnsDiscover = new Discover(100);

            Wallet JohnsFirstWallet = new Wallet();

            JohnsFirstWallet.Cards.Add(JohnsVisa);
            JohnsFirstWallet.Cards.Add(JohnsDiscover);

            Card JohnsMaster = new Master(100);

            Wallet JohnsSecondWallet = new Wallet();

            JohnsSecondWallet.Cards.Add(JohnsMaster);

            John = new Person();

            John.Wallets.Add(JohnsFirstWallet);
            John.Wallets.Add(JohnsSecondWallet);

            John.Balance.Calculate();
        }

        [Test]
        public void DisplaySecond()
        {
            John.Balance.Display();
        }
    }

    [TestFixture]
    public class ThirdWallet
    {
        public Person Jane;
        public Person Josh;

        [SetUp]
        public void Init()
        {
            Card JanesVisa = new Visa(100);
            Card JanesMaster = new Master(100);
            Card JanesDiscover = new Discover(100);

            Wallet JanesFirstWallet = new Wallet();

            JanesFirstWallet.Cards.Add(JanesVisa);
            JanesFirstWallet.Cards.Add(JanesMaster);
            JanesFirstWallet.Cards.Add(JanesDiscover);

            Jane = new Person();

            Jane.Wallets.Add(JanesFirstWallet);

            Card JoshsVisa = new Visa(100);
            Card JoshsMaster = new Master(100);

            Wallet JoshsFirstWallet = new Wallet();

            JoshsFirstWallet.Cards.Add(JoshsVisa);
            JoshsFirstWallet.Cards.Add(JoshsMaster);

            Josh = new Person();

            Josh.Wallets.Add(JoshsFirstWallet);

            Jane.Balance.Calculate();
            Josh.Balance.Calculate();
        }

        [Test]
        public void DisplayThird()
        {
            Jane.Balance.Display();
            Josh.Balance.Display();
        }
    }
}
