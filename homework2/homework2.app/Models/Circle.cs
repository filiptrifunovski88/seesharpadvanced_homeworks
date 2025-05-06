using homework2.app.Interface;

namespace homework2.app.Models
{
    public class Circle : Shape, IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public void GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
