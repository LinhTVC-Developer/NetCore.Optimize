namespace NetCore.DesignPattern.FactoriesPattern.CustomerOmniFactory
{
    public class CustomerActiveStandby : ICustomer
    {
        public string Confirm()
        {
            return string.Empty;
        }
        public string Reject()
        {
            return string.Empty;
        }
        public string Request()
        {
            return string.Empty;
        }
    }
}
