namespace _1.shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rectanle,square and triangle.");
        }
    }

    public interface IShape
    {
        double Get_space();
        bool If_legal();
    }

    public class Rectangle:IShape
    {
        private double Length;
        private double Width;

        public double Len
        {
            get { return Length; } 
            set { Length = value; }
        }  

        public double Wid
        {
            get { return Width; }
            set { Width = value; }
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Length = height;
        }
        public double Get_space()
        {
            return Length*Width;
        }
        public bool If_legal()
        {
            return(Length > 0) && (Width > 0);
        }
    }

    public class Square:IShape
    {
        private double Length;

        public double Len
        {
            get { return Length; }
            set { Length = value; }
        }

        public Square(double length)
        {
            Length = length;
        }

        public double Get_space()
        {
            return Length * Length;
        }

        public bool If_legal()
        {
            return Length > 0;
        }
    }

    public class Triangle : IShape
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Get_space()
        {
            double p = (a+b+c)/2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        public bool If_legal()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }

}
