namespace compute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int a = 0;
            int b = 0;
            int result = 0;
            bool valid = true;

            Console.WriteLine("Please input the first number:");
            s = Console.ReadLine();
            a = Int32.Parse(s);

            Console.WriteLine("Please input the second number:");
            s = Console.ReadLine();
            b = Int32.Parse(s);

            Console.WriteLine("Please input the operator:");
            s = Console.ReadLine();
            if (s == "+") result = a + b;
            else if (s == "-") result = a - b;
            else if (s == "*") result = a * b;
            else if (s == "/" && b != 0) result = a / b;
            else if (s == "%" && b != 0) result = a % b;
            else valid = false;

            if (valid) Console.WriteLine($"{result}");
            else Console.WriteLine("Invalid operation");
        }
    }
}
