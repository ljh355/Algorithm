using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 2010

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());

            int result = 1;

            for (int i = 0; i < n; i++)
            {
                int multiPlug = int.Parse(sr.ReadLine());
                result += multiPlug - 1;
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}