using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.DesignPattern.FactoriesPattern.CustomerOmniFactory.StatusCustomer
{
    public class CustomerStatusMain
    {
        ICustomer iCustomer { get; set; }

        public string Status { get; set; }

        public ICustomer CustomerStatus() {
            if(this.Status == "1")
            {
                return new CustomerActiveStandby();
            }else if(this.Status == "2")
            {
                return new CustomerActive();
            }
            else if (this.Status == "3")
            {
                return new CustomerReject();
            }
            return null;
        }
    }
}
