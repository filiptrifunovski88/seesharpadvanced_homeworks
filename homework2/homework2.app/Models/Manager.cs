namespace homework2.app.Models
{
    public class Manager : Employee
    {
        public double MonthlySalary { get; set; }

        public Manager(string name, int id, double monthlySalary)
            : base(name, id)
        {
            MonthlySalary = monthlySalary;
        }
        protected override double CalculateSalary()
        {
            return MonthlySalary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager: {Name}, ID: {ID}, Salary: {CalculateSalary()}$");
        }
    }
}
