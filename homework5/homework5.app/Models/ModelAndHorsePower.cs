namespace homework5.app.Models
{
    public class ModelAndHorsePower
    {
        public string Model { get; set; }
        public double HorsePower { get; set; }

        public void PrintInfo(List<ModelAndHorsePower> list)
        {
            foreach(ModelAndHorsePower item in list)
            {
                Console.WriteLine($"{item.Model}, {item.HorsePower}");
            }
        }

    }
}
