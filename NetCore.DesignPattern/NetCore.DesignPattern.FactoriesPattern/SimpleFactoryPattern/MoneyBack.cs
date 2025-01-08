using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.DesignPattern.FactoriesPattern.SimpleFactoryPattern
{
    public class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MasterCard";
        }

        public int GetCreditLimit()
        {
            return 1500;
        }

        public int GetAnualCharge()
        {
            return 500;
        }

        public string GetNameCard()
        {
            return "MoneyBack";
        }
    }
}
