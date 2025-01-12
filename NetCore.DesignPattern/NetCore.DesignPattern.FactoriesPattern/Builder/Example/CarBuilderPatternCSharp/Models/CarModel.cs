namespace NetCore.DesignPattern.FactoriesPattern.Builder.Example.CarBuilderPatternCSharp
{
    public class CarModel
    {
        public int Seats { get; set; }
        public CarType Type { get; set; }
        public Engine Engine { get; set; } = new Engine();
        public Transmission transmission { get; set; } = new Transmission();
        public TripCumputer tripCumputer { get; set; } = new TripCumputer();
        public Navigator Navigator { get; set; } = new Navigator();

        public string PrintCarInfo()
        {
            string carInfo = $"Type of car {Type} \n" +
                $"Count of seats: {Seats} \n" +
                $"Engine: volumn - {Engine.Volumne}; mileage - {Engine.Mileage} \n" +
                $"Transmission: {transmission} \n";
            carInfo += tripCumputer != null ? "Trip computer: Functional \n" : "Trip computer: N/A \n";
            carInfo += Navigator != null ? $"Navigator {Navigator.ToString()} \n" : "Navigator: N/A \n";
            return carInfo;
        }
    }

    public enum CarType
    {
        SPORT = 1
    }
}
