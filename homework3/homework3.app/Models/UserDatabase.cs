namespace homework3.app.Models
{
    public static class UserDatabase
    {
        public static User[] Users = new User[]
           {
            new User(1, "Filip", 19),
            new User(2, "Mihail", 20),
            new User(3, "Ivana", 24)
           };

        public static User[] Search(int id, string name, int age)
        {
            return Users.Where(u => u.ID == id && u.Name == name && u.Age == age).ToArray();
        }
    }
}
