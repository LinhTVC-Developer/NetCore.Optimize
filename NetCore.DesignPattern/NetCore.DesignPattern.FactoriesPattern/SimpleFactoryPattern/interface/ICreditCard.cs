using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.DesignPattern.FactoriesPattern.SimpleFactoryPattern
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnualCharge();
    }
}
