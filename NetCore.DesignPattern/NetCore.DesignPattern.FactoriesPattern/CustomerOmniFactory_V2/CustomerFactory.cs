using NetCore.DesignPattern.FactoriesPattern.CustomerOmniFactory;

namespace NetCore.DesignPattern.FactoriesPattern.CustomerOmniFactory_V2
{
    public class CustomerFactory : ICustomerFactory
    {
        public ICustomer CreateCustomer(string status)
        {
            return _customerMap[status];
        }

        private Dictionary<string, ICustomer> _customerMap { get; } = new Dictionary<string, ICustomer>()
        {
            {"1", new CustomerActiveStandby()},
            {"2", new CustomerActive()},
            {"3", new CustomerReject()}
        };
    }
}
