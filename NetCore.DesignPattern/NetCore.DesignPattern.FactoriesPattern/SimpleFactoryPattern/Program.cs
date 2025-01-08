namespace NetCore.DesignPattern.FactoriesPattern.SimpleFactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICreditCard creditCard = null;
            string cardType = "MoneyBack";
            switch (cardType)
            {
                case "MoneyBack": { creditCard = new MoneyBack(); break; }
                case "Titanium": { creditCard = new Titanium(); break; }
                case "Platinum": { creditCard = new Titanium(); break; };
                default: {  creditCard = new MoneyBack(); break; };
            }

            if(creditCard != null)
            {
                Console.WriteLine("CardType : " + creditCard.GetCardType());
                Console.WriteLine("CreditLimit : " + creditCard.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + creditCard.GetAnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
