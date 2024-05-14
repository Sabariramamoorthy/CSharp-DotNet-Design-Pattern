using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design
{
    public class TitaniumCard :ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "Titanium Card";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }
}
