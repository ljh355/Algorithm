using System;
using System.IO;

namespace codingTest
{
    internal class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string s = sr.ReadLine();
            char[] cArr = s.ToCharArray();

            int zeroCnt = 0;
            int oneCnt = 0;
            int result = 0;

            for (int i = 0; i < cArr.Length - 1 ; i++)
            {
                if (cArr[0] == '0')
                {
                    zeroCnt++;
                }
                else if (cArr[0] == '1')
                {
                    oneCnt++;
                }

                if (cArr[i] != cArr[i+1])
                {
                    if (cArr[i+1] == '0')
                    {
                        zeroCnt++;
                    }
                    else
                    {
                        oneCnt++;
                    }
                }
            }

            result = Math.Min(zeroCnt, oneCnt);

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}