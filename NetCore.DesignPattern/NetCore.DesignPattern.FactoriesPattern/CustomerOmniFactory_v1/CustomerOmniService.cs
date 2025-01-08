using NetCore.DesignPattern.FactoriesPattern.CustomerOmniFactory.StatusCustomer;

namespace NetCore.DesignPattern.FactoriesPattern.CustomerOmniFactory
{
    public class CustomerOmniService
    {
        private ICustomer iCustomer { get; set; }
        public CustomerOmniService()
        {
            CustomerStatusMain ts = new CustomerStatusMain();
            ts.Status = "1";
            iCustomer = ts.CustomerStatus();
        }
        public string Request()
        {
            ICustomer cus = new CustomerActiveStandby();
            return cus.Request();
        }

        public string Confirm()
        {
            ICustomer cus = new CustomerActiveStandby();
            return cus.Confirm();
        }

        public string Reject()
        {
            ICustomer cus = new CustomerActiveStandby();
            return cus.Confirm();
        }
    }
}
