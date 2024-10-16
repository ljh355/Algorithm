using System;
using System.IO;
using System.Text;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            int tc = int.Parse(sr.ReadLine());

            for (int i = 0; i < tc; i++)
            {
                sb.Append(dp(int.Parse(sr.ReadLine()))+"\n");
            }

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static int dp(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (n == 3) return 4;

            return dp(n-1)+dp(n-2)+dp(n-3);
        }
    }
}