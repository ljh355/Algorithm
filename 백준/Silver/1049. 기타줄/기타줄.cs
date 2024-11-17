using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1049

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] fristLine = sr.ReadLine().Split(' ');

            int n = int.Parse(fristLine[0]);
            int m = int.Parse(fristLine[1]);

            int lowPackgeValue = 1001;
            int lowEachValue = 1001;

            for (int i = 0; i < m; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');

                int nowPackgeValue = int.Parse(temp[0]);
                int nowEachValue = int.Parse(temp[1]);

                if (nowPackgeValue < lowPackgeValue)
                {
                    lowPackgeValue = nowPackgeValue;
                }

                if (nowEachValue < lowEachValue)
                {
                    lowEachValue = nowEachValue;
                }
            }

            int packge = n / 6;
            int each = n % 6;

            int case1 = (packge + 1) * lowPackgeValue;
            int case2 = n * lowEachValue;
            int case3 = packge * lowPackgeValue + each * lowEachValue;

            int result = Math.Min(Math.Min(case1, case2), case3);

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}