using System;

namespace PaymentConsoleApp
{
    abstract class PaymentInstrument
    {
        public String paymentType = "Card";
        public String name;
        public String cardNumber;
        public abstract void collectMoney();
       
    }
    class VisaCard:PaymentInstrument
    {
        public String CardNumber { get; set; }
        public override void collectMoney()
        {
            Console.WriteLine("Collecting money through Visa Card :"+CardNumber);
        }

    }
    class CreditCard:PaymentInstrument
    {
        public CreditCard(String cardNumber1)
        {
            cardNumber = cardNumber1;

        }
        public override void collectMoney()
        {
            Console.WriteLine("Collecting Money through Credit Card : "+cardNumber);
        }
    }
    class Paypal:PaymentInstrument
    {

        public override void collectMoney()
        {
            Console.WriteLine("Collecting money using Paypal Account with Name : "+name);
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {

            VisaCard myVisaCard = new VisaCard();
            //Using Properties
            myVisaCard.CardNumber = "VS123456";
            myVisaCard.collectMoney();
            //Using Constructors
            CreditCard myCreditCard = new CreditCard("CR123456");
            myCreditCard.collectMoney();

            Paypal myPaypal = new Paypal();
            myPaypal.name = "RRR";
            myPaypal.collectMoney();
            
            
            
        }
    }
}
