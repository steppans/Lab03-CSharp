namespace ClassLibrary03
{
    public class Car: IEquatable<Car>
    {
        public string Name { get; }
        public string Engine { get; }

        public int MaxSpeed { get;  }

        public Car(string name, string engine, int maxSpeed)
        {
            Name = name;
            Engine = engine;
            MaxSpeed = maxSpeed;
        }

        public override string? ToString()
        {
            return Name;
        }

        public bool Equals(Car? other)
        {
            switch (other)
            {
                case null:
                    return false;
                default:
                    return Name == other.Name && Engine == other.Engine && MaxSpeed == other.MaxSpeed;
            }
        }

    }

    public class CarCatalog
    {
        private List<Car> cars = new();

        public int CarNum { get; private set; }


        public CarCatalog(List<Car> cars) => (this.cars, CarNum) = (cars, cars.Count);

        public CarCatalog(params Car[] cars)
        {
            for(int i = 0; i < cars.Length; ++i)
            {
                this.cars.Add(cars[i]);
            }

            CarNum = cars.Length;
        }

        public string this[int index]
        {
            get => $"{cars[index].Name}: {cars[index].Engine}";
        }
    }
}
