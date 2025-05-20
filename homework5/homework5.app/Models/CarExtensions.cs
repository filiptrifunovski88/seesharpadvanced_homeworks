using homework5.app;

public static class CarExtensions
{
    public static void PrintEverything(this List<Car> cars)
    {
        foreach (Car car in cars)
        {
            Console.WriteLine($"Model: {car.Model}, Cylinders: {car.Cylinders}, Horsepower: {car.HorsePower}, Origin: {car.Origin}");
        }
    }
}