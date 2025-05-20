using homework5.app;
using homework5.app.Models;

// 1. Filter all cars that have origin from Europe.
List<Car> europeanCars = CarsData.Cars.Where(c => c.Origin == "Europe").ToList();
europeanCars.PrintEverything();

Console.WriteLine("======================================================================");
// 2. Find all unique cylinder values for cars.
List<int> uniqueCylinderValues = CarsData.Cars.Select(c => c.Cylinders).Distinct().ToList();
foreach(int num in uniqueCylinderValues)
{
    Console.WriteLine(num);
}
Console.WriteLine("======================================================================");

// 3. Select all car names with their model names converted to uppercase.
List<string> modelsNamesUpperCase = CarsData.Cars.Select(c => c.Model.ToUpper()).ToList();
foreach (string model in modelsNamesUpperCase)
{
    Console.WriteLine(model);
}
Console.WriteLine("======================================================================");

// 4. Check if there are any cars with horsepower greater than 300.
List<Car> carsHorsepowerGreaterThan300 = CarsData.Cars.Where(c => c.HorsePower >= 300).ToList();
if (carsHorsepowerGreaterThan300.Count == 0)
{
    Console.WriteLine("No cars with horsepower greater than 300 found.");
}
else
{
    carsHorsepowerGreaterThan300.PrintEverything();

}
Console.WriteLine("======================================================================");

// 5. Find the car with the maximum weight.
Car carWithMaximumWeight = CarsData.Cars.OrderByDescending(c => c.Weight).First();
Console.WriteLine($"{carWithMaximumWeight.Model}, {carWithMaximumWeight.Weight}");
Console.WriteLine("======================================================================");

// 6. Filter all "Chevrolet" cars and order them by weight in descending order.
List<Car> chevroletOrderByWeightDescending = CarsData.Cars.Where(c => c.Model.StartsWith("Chevrolet"))
.OrderByDescending(c => c.Weight).ToList();
chevroletOrderByWeightDescending.PrintEverything();
Console.WriteLine("======================================================================");

// 7. Find the car with the longest model name.
Car carWithLongestModelName = CarsData.Cars.OrderByDescending(c => c.Model.Length).FirstOrDefault();
Console.WriteLine($"{carWithLongestModelName.Model}, {carWithLongestModelName.Model.Length} characters");
Console.WriteLine("======================================================================");

// 8. Group cars by their origin and then order the groups by the number of cars in each group, in ascending order.
List<IGrouping<string, Car>> groupedCarsList = CarsData.Cars.GroupBy(c => c.Origin).OrderBy(g => g.Count()).ToList();

// 9. Find the first 5 cars with the highest horsepower. (hint: read about LINQ methods Skip() and Take())
List<Car> top5CarsByHorsePower = CarsData.Cars.OrderByDescending(c => c.HorsePower).Take(5).ToList();
top5CarsByHorsePower.PrintEverything();
Console.WriteLine("======================================================================");

// 10. Find the car with the highest acceleration time.
Car carWithHighestAccelerationTime = CarsData.Cars.OrderByDescending(c => c.AccelerationTime).FirstOrDefault();
Console.WriteLine($"{carWithHighestAccelerationTime.Model}, {carWithHighestAccelerationTime.AccelerationTime}");

// 11. Select only the model and horsepower of cars with horsepower greater than 200.
List<ModelAndHorsePower> modelAndHorsepowerGreaterThan200 = CarsData.Cars
    .Where(c => c.HorsePower > 200)
    .Select(c => new ModelAndHorsePower { Model = c.Model, HorsePower = c.HorsePower })
    .ToList();
foreach (ModelAndHorsePower item in modelAndHorsepowerGreaterThan200)
{
    Console.WriteLine($"{item.Model}, {item.HorsePower}");
}
Console.WriteLine("======================================================================");

// 12. Select all unique origins of cars, ordered alphabetically (ascending).
List<string> uniqueOriginsOfCarsOrderAlpabeticlly = CarsData.Cars.Select(c => c.Origin).Distinct().OrderBy(origin => origin).ToList();
foreach (string origin in uniqueOriginsOfCarsOrderAlpabeticlly)
{
    Console.WriteLine(origin);
}
Console.WriteLine("======================================================================");

// 13. Select all cars with more than 4 cylinders, and order them by origin and then by horsepower.
List<Car> cylinders4OrderOriginHorsepower = CarsData.Cars
    .Where(c => c.Cylinders > 4)
    .OrderBy(c => c.Origin)
    .ThenBy(c => c.HorsePower)
    .ToList();
cylinders4OrderOriginHorsepower.PrintEverything();
Console.WriteLine("======================================================================");

// 14. Filter all cars that have more than 6 Cylinders not including 6 after that Filter all cars that have
// exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result.
List<Car> sixCylindersCars = CarsData.Cars
    .Where(c => c.Cylinders == 6)
    .ToList();

List<Car> fourCylindersHighHpCars = CarsData.Cars
    .Where(c => c.Cylinders == 4 && c.HorsePower > 110.0)
    .ToList();

List<Car> combinedResult = sixCylindersCars
    .Concat(fourCylindersHighHpCars)
    .ToList();

combinedResult.PrintEverything();
Console.WriteLine("======================================================================");

// 15. Filter all cars that have more then 200 HorsePower
// and Find out how much is the lowest, highest and average Miles per galon for these cars.
List<Car> carsWithMoreThan200HP = CarsData.Cars
    .Where(c => c.HorsePower > 200)
    .ToList();
double minMilesPerGallon = carsWithMoreThan200HP.Min(c => c.MilesPerGalon);
double maxMilesPerGallon = carsWithMoreThan200HP.Max(c => c.MilesPerGalon);
double avgMilesPerGallon = carsWithMoreThan200HP.Average(c => c.MilesPerGalon);
Console.WriteLine($"Min MPG: {minMilesPerGallon}");
Console.WriteLine($"Max MPG: {maxMilesPerGallon}");
Console.WriteLine($"Avg MPG: {avgMilesPerGallon:F2}");
Console.WriteLine("======================================================================");

// 16. Be creative and write requirement of your own choice :) (only one catch, must use at least 3 LINQ methods)
// Find all cars originating from the "US" that have more than 6 cylinders, ordered by horsepower in descending order.
// From these cars, select only the model and weight, then take the first 5 results.

List<Car> topHeavyUsCars = CarsData.Cars
    .Where(c => c.Origin == "US" && c.Cylinders > 6)
    .OrderByDescending(c => c.HorsePower)
    .ToList();
List<ModelAndWeight> selectOnlyTheModelAndWeight = topHeavyUsCars
    .Select(c => new ModelAndWeight { Model = c.Model, Weight = c.Weight })
    .Take(5)
    .ToList();
foreach (ModelAndWeight item in selectOnlyTheModelAndWeight)
{
    Console.WriteLine($"Model: {item.Model}, Weight: {item.Weight}");
}

// 17. Be creative and write requirement of your own choice :) (only one catch, must use at least 3 LINQ methods)
// Find all cars that have more than 4 cylinders, then group them by origin, and for each group, select the average
// horsepower and the car with the maximum horsepower. Finally, order the groups by the average horsepower in descending order.
List<Car> carsWithMoreThan4Cylinders = CarsData.Cars
    .Where(c => c.Cylinders > 4)
    .ToList();
List<IGrouping<string, Car>> groupedByOrigin = carsWithMoreThan4Cylinders
    .GroupBy(c => c.Origin)
    .OrderByDescending(g => g.Average(c => c.HorsePower))
    .ToList();
List<Car> maxHorsepowerCarsByOrigin = groupedByOrigin
    .Select(g => g.OrderByDescending(c => c.HorsePower).First())
    .ToList();
maxHorsepowerCarsByOrigin.PrintEverything();