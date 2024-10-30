using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            int n = int.Parse(sr.ReadLine());

            List<int> a = new List<int>();
            List<int> b = new List<int>();

            string[] temp1 = sr.ReadLine().Split(' ');
            string[] temp2 = sr.ReadLine().Split(' ');

            int result = 0;

            for (int i = 0; i < n; i++)
            {
                a.Add(int.Parse(temp1[i]));
                b.Add(int.Parse(temp2[i]));
            }


            while(a.Count > 0)
            {
                result += a.Min() * b.Max();
                a.Remove(a.Min());
                b.Remove(b.Max());
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}