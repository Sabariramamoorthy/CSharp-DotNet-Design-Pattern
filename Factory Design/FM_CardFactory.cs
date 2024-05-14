using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design
{
    public abstract class FM_CardFactory
    {
        public abstract ICreditCard GetCreditCard();
    }

    public class Moneybackfactory : FM_CardFactory
    {
        public override ICreditCard GetCreditCard()
        {
            return new MoneyBackCard();
        }
    }

    public class Titaniumfactory : FM_CardFactory
    {
        public override ICreditCard GetCreditCard()
        {
            return new TitaniumCard();
        }
    }

    public class Platinumfactory : FM_CardFactory
    {
        public override ICreditCard GetCreditCard()
        {
            return new PlatinumCard();
        }
    }
}
