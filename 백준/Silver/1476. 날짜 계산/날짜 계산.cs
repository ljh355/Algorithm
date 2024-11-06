using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static int e = 0;
        static int s = 0;
        static int m = 0;
        static void Main()
        {
            // 백준 1476
            
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] firstLine = sr.ReadLine().Split(' ');

            e = int.Parse(firstLine[0]);
            s = int.Parse(firstLine[1]);
            m = int.Parse(firstLine[2]);

            int result = CalDate(1, 1, 1);

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static int CalDate(int a, int b, int c)
        {
            int cnt = 1;

            while (true)
            {
                if (e == a && s == b && m == c)
                {
                    return cnt;
                }

                a++;
                b++;
                c++;
                cnt++;

                if (a > 15) a = 1;
                if (b > 28) b = 1;
                if (c > 19) c = 1;
            }
        }
    }
}