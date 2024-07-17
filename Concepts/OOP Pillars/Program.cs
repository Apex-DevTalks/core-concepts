public class OOP_Pillars
{
    public interface IPrintable
    {
        void PrintArea();
    }

    public abstract class Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Radius { get; set; }

        public abstract double CalculateArea();
    }

    public class Square : Shape, IPrintable
    {
        public Square(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override double CalculateArea()
        {
            return Height * Width;
        }

        public void PrintArea()
        {
            Console.WriteLine("The square's area is: {0}", CalculateArea());
        }
    }

    public class Triangle : Shape, IPrintable
    {
        public Triangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override double CalculateArea()
        {
            return Height * Width / 2;
        }

        public void PrintArea()
        {
            Console.WriteLine("The triangle's area is: {0}", CalculateArea());
        }
    }

    public class Circle : Shape, IPrintable
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI*(Radius*Radius);
        }

        public void PrintArea()
        {
            Console.WriteLine("The circle's area is: {0}", CalculateArea());
        }
    }

    static void MyMyMain(string[] args)
    {
        Square square = new(2, 2);
        square.PrintArea();

        Triangle triangle = new(2, 2);
        triangle.PrintArea();

        Circle circle = new(2);
        circle.PrintArea();

    }
}