namespace _2.ShapeFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[10];

            //随机创建十个对象
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int type = random.Next(0, 3);
                if (type == 0)
                    shapes[i] = ShapeFactory.CreateShape("rectangle", random.NextDouble(), random.NextDouble());
                else if (type == 1)
                    shapes[i] = ShapeFactory.CreateShape("square", random.NextDouble());
                else if (type == 2)
                    shapes[i] = ShapeFactory.CreateShape("triangle", random.NextDouble(), random.NextDouble(), random.NextDouble());
            }

            Console.WriteLine("生成的图形信息:");
            foreach (var shape in shapes)
            {
                if (shape.If_legal())
                {
                    Console.WriteLine($"{shape.GetType().Name}, 面积: {shape.Get_space():F2}");
                }
                else
                {
                    Console.WriteLine($"{shape.GetType().Name} 不是合法图形");
                }
            }
        }
    }

    public interface IShape
    {
        double Get_space();
        bool If_legal();
    }

    public class Rectangle : IShape
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
            return Length * Width;
        }
        public bool If_legal()
        {
            return (Length > 0) && (Width > 0);
        }
    }

    public class Square : IShape
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
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool If_legal()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }

    public class ShapeFactory
    {
        public static IShape CreateShape(string ShapeType, params double[] parameters)
        {
            if (ShapeType == "rectangle" && parameters.Length == 2)
            {
                return new Rectangle(parameters[0], parameters[1]);
            }
            else if (ShapeType == "square" && parameters.Length == 1)
            {
                return new Square(parameters[0]);
            }
            else if (ShapeType == "triangle" && parameters.Length == 3)
            {
                return new Triangle(parameters[0], parameters[1], parameters[2]);
            }
            else
            {
                Console.WriteLine("无效的参数类型或参数错误。");
                return null;
            }
        }
    }
}
