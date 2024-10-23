using System;
using System.IO;
using System.Text;

namespace CodingTest
{
    internal class Program
    {
        static int[] memo = new int[41];

        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            int t = int.Parse(sr.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int temp = int.Parse(sr.ReadLine());

                memo = new int[41];

                Fibo(temp);

                if (temp == 0)
                {
                    sb.Append(1 + " " + 0 + "\n");
                }
                else
                {
                    sb.Append(memo[temp - 1] + " " + memo[temp] + "\n");
                }
            }

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static int Fibo(int n)
        {
            if (n == 0)
            {
                memo[0] = 0;
                return 0;
            }
            else if (n == 1)
            {
                memo[1] = 1;
                return 1;
            }
            else if (memo[n] != 0)
            {
                return memo[n];
            }
            memo[n] = Fibo(n - 1) + Fibo(n - 2);
            return memo[n];
        }
    }
}