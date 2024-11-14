using System;
using System.IO;

namespace codingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 14912

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] firstLine = sr.ReadLine().Split(' ');

            int n = int.Parse(firstLine[0]);
            int d = int.Parse(firstLine[1]);
            int cnt = 0;

            while(n>0)
            {
                int tmpN = n;
                while(tmpN > 0)
                {
                    int digit = tmpN % 10;

                    if (digit == d)
                    {
                        cnt++;
                    }

                    tmpN /= 10;
                }
                n--;
            }

            sw.Write(cnt);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}