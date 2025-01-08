using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.DesignPattern.FactoriesPattern.SimpleFactoryPattern
{
    public class Platium : ICreditCard
    {
        public string GetCardType()
        {
            return "Visa";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }

        public int GetAnualCharge()
        {
            return 1500;
        }

        public string GetNameCard()
        {
            return "Platium";
        }
    }
}
