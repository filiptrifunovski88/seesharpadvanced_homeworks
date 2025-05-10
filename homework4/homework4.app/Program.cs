using homework4.app.Helpers;
using homework4.app.Models;

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();

((Car)car).Drive();
((MotorBike)motorBike).Wheelie();
((Boat)boat).Sail();
((Airplane)plane).Fly();

List<string> stringsList = new()
{
    "Filip", "Mihail", "Ivana", "Ana"
};

PrintInConsole printInConsole = new();

printInConsole.Print(123);
printInConsole.Print("I am string");
printInConsole.Print(true);

printInConsole.PrintCollection(stringsList);