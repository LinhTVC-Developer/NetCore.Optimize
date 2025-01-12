namespace NetCore.DesignPattern.FactoriesPattern.Builder.Example.CarBuilderPatternCSharp
{
    public class AutoCarModelBuilder : ICarModelBuilder
    {
        private CarModel carModel = new CarModel();

        public void SetSeats(int seats)
        {
            carModel.Seats = seats;
        }

        public void SetType(CarType type)
        {
            carModel.Type = type;
        }

        public void SetEngine(Engine engine)
        {
            carModel.Engine = engine;
        }

        public CarModel Build()
        {
            return carModel;
        }
    }
}