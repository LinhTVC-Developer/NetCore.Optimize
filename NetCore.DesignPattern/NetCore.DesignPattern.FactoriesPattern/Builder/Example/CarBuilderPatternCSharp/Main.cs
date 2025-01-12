using NetCore.DesignPattern.FactoriesPattern.Builder.Example.CarBuilderPatternCSharp.Models;

namespace NetCore.DesignPattern.FactoriesPattern.Builder.Example.CarBuilderPatternCSharp
{
    public class Main
    {
        public void main()
        {
            CarModelDirector director = new CarModelDirector();
            ICarModelBuilder carModelBuilder = new AutoCarModelBuilder();
            CarModel car = director.Build(carModelBuilder);
            Console.WriteLine(car.PrintCarInfo());
        }
    }
}
