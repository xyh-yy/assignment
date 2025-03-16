using System.Diagnostics.CodeAnalysis;

namespace HW1
{
    internal class Program
    {
        static double sum = 0;//当前所有数的和
        static int num_cnt = 0;//当前已遍历的数的个数
        static double average = 0;//均值
        static double max = double.MinValue;//最大值
        static double min = double.MaxValue;//最小值
        static void Main(string[] args)
        {
            Action<double> action = delegate (double x)//计算平均值
            {
                sum += x;
                num_cnt++;
                average = sum/ num_cnt;
            };

            action += delegate (double x)//找出最大值
            {
                if (x > max) max = x;
            };
            action += delegate (double x)//找出最小值
            {
                if (x < min) min = x;
            };

            List<double> numbers = new List<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            numbers.ForEach(action);
            Console.WriteLine($"平均值是{average}");
            Console.WriteLine($"最大值是{max}");
            Console.WriteLine($"最小值是{min}");
        }

        
    }
}
