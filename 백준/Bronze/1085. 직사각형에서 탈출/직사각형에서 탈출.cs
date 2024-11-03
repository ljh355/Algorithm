using System;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] firstLine = sr.ReadLine().Split(' ');

            int x = int.Parse(firstLine[0]);
            int y = int.Parse(firstLine[1]);
            int w = int.Parse(firstLine[2]);
            int h = int.Parse(firstLine[3]);

            int result = Math.Min(Math.Min(w-x, x),Math.Min(h-y, y));

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}