namespace NetCore.DesignPattern.FactoriesPattern.CustomerOmniFactory
{
    public class CustomerReject : ICustomer
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
