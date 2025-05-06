namespace homework3.app.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public User(int iD, string name, int age)
        {
            ID = iD;
            Name = name;
            Age = age;
        }
    }
}
