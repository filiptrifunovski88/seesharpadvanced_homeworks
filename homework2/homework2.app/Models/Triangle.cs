using homework2.app.Interface;

namespace homework2.app.Models
{
    public class Triangle : Shape, IShape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Height { get; set; }

        public Triangle(double side1, double side2, double side3, double height)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Side1 * Height;
        }

        public override double CalculatePerimeter()
        {
            return Side1 + Side2 + Side3;
        }
        public void GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
