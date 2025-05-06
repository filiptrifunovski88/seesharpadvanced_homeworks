namespace homework2.app.Models
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Employee(string name, int id)
        {
            Name = name;
            ID = id;
        }
        protected abstract double CalculateSalary();
        public abstract void DisplayInfo();
    }
}
