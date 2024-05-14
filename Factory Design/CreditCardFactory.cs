using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string argType)
        {
            switch (argType)
            {
                case "Moneyback":
                    return new MoneyBackCard();
                case "Titanium":
                    return new TitaniumCard();
                case "Platinum":
                    return new PlatinumCard();
                default:
                    throw new ArgumentException("Invalid Card Type");

            }
        }
    }
}
