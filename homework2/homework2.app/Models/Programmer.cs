namespace homework2.app.Models
{
    public class Programmer : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public Programmer(string name, int id, double hourlyRate, int hoursWorked)
            : base(name, id)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }
        protected override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Programmer: {Name}, ID: {ID}, Salary: {CalculateSalary()}$");
        }
    }
}
