namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组长度：");
            int len = int.Parse(Console.ReadLine());
            int[]input = new int[len];
            Console.WriteLine("请输入一个数组，以换行分开");
            for (int i = 0; i < len; i++) input[i] = int.Parse(Console.ReadLine());
            int max, min;
            double mean;
            arr(input, out max, out min, out mean);
            Console.WriteLine("max = {0} , min = {1} , mean = {2}", max, min, mean);
        }

        static bool arr(int[] input, out int max, out int min, out double mean)
        {
            max = min = 0;
            mean = 0;
            if (input == null) return false;
            max = min = input[0];

            double sum = input[0];
            for(int i = 1; i < input.Length; i++)
            {
                if (input[i] < max) max = input[i];
                if (input[i] > min) min = input[i];
                sum += input[i];
            }
            mean = sum / input.Length;
            return true;
        }
    }
}
