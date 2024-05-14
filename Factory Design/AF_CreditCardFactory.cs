using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design
{
    public interface AF_CreditCardFactory
    {
        ICreditCard CreateCreditCard();
    }

    public class AF_Moneybackfactory : AF_CreditCardFactory
    {
        
        ICreditCard AF_CreditCardFactory.CreateCreditCard()
        {
            return new MoneyBackCard();
        }
    }

    public class AF_Titaniumfactory : AF_CreditCardFactory
    {
        ICreditCard AF_CreditCardFactory.CreateCreditCard()
        {
            return new TitaniumCard();
        }
    }

    public class AF_Platinumfactory : AF_CreditCardFactory
    {
        ICreditCard AF_CreditCardFactory.CreateCreditCard()
        {
            return new PlatinumCard();
        }
    }


}
