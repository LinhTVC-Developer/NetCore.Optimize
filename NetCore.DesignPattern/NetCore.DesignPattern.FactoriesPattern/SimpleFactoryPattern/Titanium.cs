using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.DesignPattern.FactoriesPattern.SimpleFactoryPattern
{
    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Master";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }

        public int GetAnualCharge()
        {
            return 2000;
        }

        public string GetNameCard()
        {
            return "Platinum Plus";
        }
    }
}
