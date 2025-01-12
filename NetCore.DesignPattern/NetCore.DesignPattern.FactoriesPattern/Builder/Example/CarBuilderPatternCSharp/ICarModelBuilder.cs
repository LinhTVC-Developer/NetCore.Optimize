namespace NetCore.DesignPattern.FactoriesPattern.Builder.Example.CarBuilderPatternCSharp
{
    public interface ICarModelBuilder
    {
        void SetSeats(int seats);

        void SetType(CarType type);

        void SetEngine(Engine engine);

        CarModel Build();
    }
}
