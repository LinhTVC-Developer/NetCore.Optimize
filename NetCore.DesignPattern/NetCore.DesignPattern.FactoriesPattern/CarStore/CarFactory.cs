namespace NetCore.DesignPattern.FactoriesPattern.CarStore
{
    public class CarFactory
    {
        public void viewCar(String carType)
        {
            ICarObj car;
            if (carType.Equals("HONDA"))
            {
                car = new HondaObj();
                car.view();
            }
            else if (carType.Equals("NEXUS"))
            {
                car = new NexusObj();
                car.view();
            }
            else if (carType.Equals("TOYOTA"))
            {
                car = new ToyotaObj();
                car.view();
            }
        }
    }
}
