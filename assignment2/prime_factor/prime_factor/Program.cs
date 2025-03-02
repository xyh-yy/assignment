namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入指定的数据：");
            int input = int.Parse(Console.ReadLine());
            int[] result;
            int result_count;
            Prime(input, out result, out result_count);
            for(int i = 0; i < result_count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        static void Prime(int input,out int[] result, out int result_count)
        {
            int count = 1;
            int[]prm = new int[input];
            prm[0] = 2;
            for(int i = 3;i <= input;i++)
            {
                for(int j = 0;j <= count-1;j++)
                {
                    if (i % prm[j] == 0) break;
                    if (j < count - 1) continue;
                    prm[count] = i;
                    count++;
                }
            }
            
            result = new int[count];
            result_count = 0;
            for(int i = 0; i < count;i++)
            {
                if (input % prm[i] != 0) continue;
                while (input % prm[i] == 0) input = input/prm[i];
                result[result_count] = prm[i];
                result_count++;
            }
        }
    }
}
