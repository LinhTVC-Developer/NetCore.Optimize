namespace NetCore.DesignPattern.FactoriesPattern.BuilderFactory
{
    public class CustomerActionBuilder
    {
        public int Status { get; set; }
        public bool IsBtnLock { get; set; }
        public bool IsBtnUnLock { get; set; }
        public bool IsBtnViewDetail { get; set; }
        public bool IsBtnUpdate { get; set; }

        public CustomerActionBuilder Builder(CustomerStatus status) {
            switch (status)
            {
                case CustomerStatus.Active:
                    {
                        this.IsBtnUpdate = true;
                        this.IsBtnLock = true;
                        return this;
                    }
                default: { throw new Exception("Status not exist");  }
            }
        }
    }

    public enum CustomerStatus
    {
        ActiveStandBy = 0,
        Active = 1,
        Inactive = 2,
        AutoLock = 3,
        PendingActive = 4
    }
}
