namespace NetCore.DesignPattern.FactoriesPattern.CarStore
{
    public class Boss
    {
        public void viewHonda()
        {
            HondaObj honda = new HondaObj();
            honda.view();
        }

        public void viewNexus()
        {
            NexusObj nexus = new NexusObj();
            nexus.view();
        }

        public void viewToyota()
        {
            ToyotaObj toyota = new ToyotaObj();
            toyota.view();
        }

        public void viewCar()
        {
            CarFactory carFactory = new CarFactory();
            carFactory.viewCar("HONDA");
            carFactory.viewCar("NEXUS");
            carFactory.viewCar("TOYOTA");
        }
    }
}
