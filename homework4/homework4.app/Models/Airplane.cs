﻿namespace homework4.app.Models
{
    public class Airplane : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Im a plane i have couple of wheels :)");
        }

        public void Fly()
        {
            Console.WriteLine("The airplane is flying");
        }
    }
}
