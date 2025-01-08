using NetCore.DesignPattern.FactoriesPattern.CustomerOmniFactory;

namespace NetCore.DesignPattern.FactoriesPattern.CustomerOmniFactory_V2
{
    public interface ICustomerFactory
    {
        ICustomer CreateCustomer(string status);
    }
}
