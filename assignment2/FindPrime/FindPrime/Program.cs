using System.Security.Cryptography;

namespace FindPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("以下为2到100间的素数：");
            bool[] result;
            FindPrime(out result);
            for (int i = 2; i < result.Length; i++) 
                if(result[i]) Console.Write("{0} ",i);
        }

        static void FindPrime(out bool[] result)
        {
            result = new bool[101];
            for(int i = 0; i < result.Length; i++) result[i] = true;

            for (int i = 3;i < 101; i++)
            {
                for (int j = 2;j <= Math.Sqrt(i); j++)
                {
                    if (i % j != 0) continue;
                    result[i] = false;
                    break;
                }
            }
        }
    }
}
