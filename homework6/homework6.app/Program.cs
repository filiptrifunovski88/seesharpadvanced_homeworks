using homework6.app.Models;


// 1. Select the horsepower of US cars with more than 150 horsepower.
Console.WriteLine("\n==================================================== 1 ====================================================\n");
List<Car> horsepowerOfUS150 = CarsData.Cars
    .Where(c => c.Origin == "US" && c.HorsePower > 150)
    .ToList();
horsepowerOfUS150.PrintEverything();

// 2. Select the weight of European cars with less than 100 horsepower.
Console.WriteLine("\n==================================================== 2 ====================================================\n");
List<Car> europianLessThan100 = CarsData.Cars
    .Where(c => c.Origin == "Europe" && c.HorsePower < 100)
    .ToList();
europianLessThan100.PrintEverything();

// 3. Select the origin of Japanese cars that weigh less than 2200.
Console.WriteLine("\n==================================================== 3 ====================================================\n");
List<Car> japaneseWeighLessThan2200 = CarsData.Cars
    .Where(c => c.Origin == "Japan" && c.Weight < 2200)
    .ToList();
japaneseWeighLessThan2200.PrintEverything();

// 4. Select the cylinder count of US cars with exactly 8 cylinders.
Console.WriteLine("\n==================================================== 4 ====================================================\n");
int count = CarsData.Cars.Count(c => c.Origin == "US" && c.Cylinders == 8);
Console.WriteLine(count);

// 5. Select the miles per gallon of cars with more than 25 miles per gallon and acceleration time over 15 seconds.
Console.WriteLine("\n==================================================== 5 ====================================================\n");
List<Car> milesPerGallon25MilesPerGallon = CarsData.Cars
    .Where(c => c.MilesPerGalon > 25 && c.AccelerationTime > 15)
    .ToList();
milesPerGallon25MilesPerGallon.PrintEverything();

// 6. Get the acceleration time of the last 4-cylinder car with acceleration time less than 15 seconds.
Console.WriteLine("\n==================================================== 6 ====================================================\n");
Car cylinder4CarLess15Seconds = CarsData.Cars
    .Where(c => c.Cylinders == 4 && c.AccelerationTime < 15)
    .LastOrDefault();

if (cylinder4CarLess15Seconds != null)
{
    Console.WriteLine($"Acceleration time: {cylinder4CarLess15Seconds.AccelerationTime}");
}
else
{
    Console.WriteLine("No 4-cylinder car found with acceleration time less than 15 seconds.");
}

// 7. Get the model name of the first car that has 0 horsepower.
Console.WriteLine("\n==================================================== 7 ====================================================\n");
Car firstCarThatHas0Horsepower = CarsData.Cars
    .FirstOrDefault(c => c.HorsePower == 0);
if (firstCarThatHas0Horsepower != null)
{
    Console.WriteLine($"Model: {firstCarThatHas0Horsepower.Model}");
}
else
{
    Console.WriteLine("No car found");
}

// 8.Get the weight of the last Japanese car with more than 90 horsepower.
Console.WriteLine("\n==================================================== 8 ====================================================\n");
Car japaneseCar90horsepower = CarsData.Cars
    .LastOrDefault(c => c.HorsePower == 90);
if (japaneseCar90horsepower != null)
{
    Console.WriteLine($"Weight: {japaneseCar90horsepower.Weight}");
}
else
{
    Console.WriteLine("No car found");
}

// 9. Get the horsepower of the first US car that weighs more than 4000 and has fewer than 6 cylinders.
Console.WriteLine("\n==================================================== 9 ====================================================\n");
Car firdtUSCar4000weightsAnd6cylinders = CarsData.Cars
    .FirstOrDefault(c => c.Origin == "US" && c.Weight > 4000 && c.Cylinders < 6);
if (firdtUSCar4000weightsAnd6cylinders != null)
{
    Console.WriteLine($"Horsepower: {firdtUSCar4000weightsAnd6cylinders.HorsePower}");
}
else
{
    Console.WriteLine("No car found");
}

// 10. Get the origin of the last car with acceleration time greater than 20 seconds.
Console.WriteLine("\n==================================================== 10 ====================================================\n");
Car originLastCarAccelerationGreaterThan20 = CarsData.Cars
    .LastOrDefault(c => c.AccelerationTime > 20);
if(originLastCarAccelerationGreaterThan20 != null)
{ 
    Console.WriteLine($"Origin: {originLastCarAccelerationGreaterThan20.Origin}");
}
else
{
    Console.WriteLine("No car found");
}