namespace NetCore.DesignPattern.FactoriesPattern.Builder.Example.CarBuilderPatternCSharp
{
    public class CarModelDirector {
        public CarModel Build(ICarModelBuilder carModelBuilder)
        {
            carModelBuilder.SetSeats(4); // default value
            carModelBuilder.SetType(CarType.SPORT); // default value
            carModelBuilder.SetEngine(new Engine { Volumne = 3, Mileage = 4 }); // default value

            // Allow customization through setters
            carModelBuilder.SetSeats(2); // Example customization
            carModelBuilder.SetEngine(new Engine { Volumne = 5, Mileage = 2 }); // Example customization

            return carModelBuilder.Build();
        }
    }
}
