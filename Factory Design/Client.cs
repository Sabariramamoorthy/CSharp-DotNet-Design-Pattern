namespace Factory_Design
{
    public class Client
    {
        public void DisplayCardDetails(FM_CardFactory fM_CardFactory)
        {
            var card = fM_CardFactory.GetCreditCard();
            Console.WriteLine($"Card Type: {card.GetCardType()}\n" +
               $"Card Annual Charges: {card.GetAnnualCharge()}\n" +
               $"Card CreditLimit : {card.GetCreditLimit()}");
            Console.WriteLine("\n**********************");

        }
        public void GetFactory()
        {
            ICreditCard card = CreditCardFactory.GetCreditCard("Moneyback");
            Console.WriteLine($"Card Type: {card.GetCardType()}\n" +
                $"Card Annual Charges: {card.GetAnnualCharge()}\n" +
                $"Card CreditLimit : {card.GetCreditLimit()}");

            Console.WriteLine("\n**********************");

            card = CreditCardFactory.GetCreditCard("Titanium");
            Console.WriteLine($"Card Type: {card.GetCardType()}\n" +
                $"Card Annual Charges: {card.GetAnnualCharge()}\n" +
                $"Card CreditLimit : {card.GetCreditLimit()}");

            Console.WriteLine("\n**********************");

            card = CreditCardFactory.GetCreditCard("Platinum");
            Console.WriteLine($"Card Type: {card.GetCardType()}\n" +
                $"Card Annual Charges: {card.GetAnnualCharge()}\n" +
                $"Card CreditLimit : {card.GetCreditLimit()}");

            Console.ReadLine();
        }


        public void FM_GetFactory()
        {

            FM_CardFactory _moneyBackFactory = new Moneybackfactory();
            FM_CardFactory _titaniumFactory = new Titaniumfactory();
            FM_CardFactory _platinumFactory = new Platinumfactory();


            DisplayCardDetails(_moneyBackFactory);
            DisplayCardDetails(_titaniumFactory);
            DisplayCardDetails(_platinumFactory);

            Console.ReadLine();
        }

        public void AF_GetFactory()
        {

            AF_CreditCardFactory _moneyBackFactory = new AF_Moneybackfactory();
            AF_CreditCardFactory _titaniumFactory = new AF_Titaniumfactory();
            AF_CreditCardFactory _platinumFactory = new AF_Platinumfactory();

         
            var card = _moneyBackFactory.CreateCreditCard();
            Console.WriteLine($"Card Type: {card.GetCardType()}\n" +
               $"Card Annual Charges: {card.GetAnnualCharge()}\n" +
               $"Card CreditLimit : {card.GetCreditLimit()}");
            Console.WriteLine("\n**********************");

            card = _titaniumFactory.CreateCreditCard();
            Console.WriteLine($"Card Type: {card.GetCardType()}\n" +
               $"Card Annual Charges: {card.GetAnnualCharge()}\n" +
               $"Card CreditLimit : {card.GetCreditLimit()}");
            Console.WriteLine("\n**********************");


            card = _platinumFactory.CreateCreditCard();
            Console.WriteLine($"Card Type: {card.GetCardType()}\n" +
               $"Card Annual Charges: {card.GetAnnualCharge()}\n" +
               $"Card CreditLimit : {card.GetCreditLimit()}");
            Console.WriteLine("\n**********************");


            Console.ReadLine();
        }
    }
}
