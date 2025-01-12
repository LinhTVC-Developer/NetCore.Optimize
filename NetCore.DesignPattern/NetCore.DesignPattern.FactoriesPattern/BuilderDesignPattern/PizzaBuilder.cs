namespace NetCore.DesignPattern.FactoriesPattern.BuilderFactory
{
    public class Pizza
    {
        public int Size { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Bacon { get; set; }

        public Pizza WithSize(int size)
        {
            this.Size = size;
            return this;
        }

        public Pizza WithCheese(bool cheese)
        {
            this.Cheese = cheese;
            return this;
        }

        public Pizza WithPepperoni(bool pepperoni)
        {
            this.Pepperoni = pepperoni;
            return this;
        }

        public Pizza WithBacon(bool bacon)
        {
            this.Bacon = bacon;
            return this;
        }
    }

    public class Builder
    {
        Pizza myPizza = new Pizza()
                        .WithSize(12)
                        .WithCheese(true)
                        .WithPepperoni(true)
                        .WithBacon(false);


    }
}
