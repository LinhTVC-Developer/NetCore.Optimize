using NetCore.DesignPattern.FactoriesPattern.CustomerOmniFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.DesignPattern.FactoriesPattern.CustomerOmniFactory_V2
{
    public class CustomerOmniService
    {
        private readonly ICustomerFactory _customerFactory;

        public CustomerOmniService(ICustomerFactory customerFactory)
        {
            _customerFactory = customerFactory;
        }

        public string Request(string customerStatus)
        {
            ICustomer customer = _customerFactory.CreateCustomer(customerStatus);
            return customer?.Request() ?? string.Empty;
        }

        public string Confirm(string customerStatus)
        {
            ICustomer customer = _customerFactory.CreateCustomer(customerStatus);
            return customer?.Confirm() ?? string.Empty;
        }

        public string Reject(string customerStatus)
        {
            ICustomer customer = _customerFactory.CreateCustomer(customerStatus);
            return customer?.Reject() ?? string.Empty;
        }
    }
}
