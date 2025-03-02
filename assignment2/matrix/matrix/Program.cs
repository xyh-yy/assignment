namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double[,] martix = { {1,2,3,4 }, {5,1,2,3 }, {9,5,1,2 } };
            //bool result = Martix(martix, 3, 4);
            Console.WriteLine("矩阵的行数：");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("矩阵的列数：");
            int column = int.Parse(Console.ReadLine());
            double[,] martix = new double[row, column];
            for(int i = 0;i<row;i++)
            {
                Console.WriteLine("请输入第一行的数据(按空格分开)：");
                string input = Console.ReadLine();
                string[] stringArray = input.Split(' ');
                for (int j = 0; j < column; j++) martix[i,j]=double.Parse(stringArray[j]);
            }
            bool result = Martix(martix, row, column);
            Console.WriteLine(result);
        }

        static bool Martix(double[,] input, int row, int column)
        {
            for(int i = 1; i < row; i++)
            {
                for(int j = 1; j < column; j++)
                {
                    if (input[i, j] != input[i - 1, j - 1]) return false;
                }
            }
            return true;
        }
    }
}
