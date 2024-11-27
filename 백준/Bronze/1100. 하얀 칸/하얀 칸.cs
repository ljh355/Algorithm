using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1100

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int result = 0;

            // 첫 번째 줄 (0,0), (0,2) ... 흰색
            // 두 번째 줄 (1,1), (1,3) ... 흰색

            for (int i = 0; i < 8; i++)
            {
                char[] temp = sr.ReadLine().ToCharArray();

                for (int j = 0; j < temp.Length; j++)
                {
                    if (i % 2 == 0) // 0, 2, 4..
                    {
                        if (j % 2 == 0 && temp[j] == 'F')
                        {
                            result++;
                        }
                    }
                    else
                    {
                        if (j % 2 != 0 && temp[j] == 'F')
                        {
                            result++;
                        }
                    }
                }
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}