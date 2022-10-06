using ClassLibrary03;

Car car1 = new("BMW", "B134-U54", 220);
Car car2 = new("Porsche", "V78-05-OL12", 230);
Car car3 = new("Jeep", "P08-345-N", 200);

var CarList = new List<Car>();
CarList.Add(car1);
CarList.Add(car2);
CarList.Add(car3);

Console.WriteLine("Write cars in console:");

foreach (Car car in CarList)
{
    Console.WriteLine(car);
}

var carCatalog = new CarCatalog(car1, car2, car3);

Console.WriteLine($"{Environment.NewLine}Write catalog of cars");

for (int i = 0; i < carCatalog.CarNum; i++)
{
    Console.WriteLine(carCatalog[i]);
}
