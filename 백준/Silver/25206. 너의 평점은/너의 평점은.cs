using System;
using System.IO;

namespace codingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 252026

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            double credit = 0;
            double grade = 0;

            for (int i = 0; i < 20; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');

                if (temp[2] == "P")
                {
                    continue;
                }

                double nowCredit = double.Parse(temp[1]);

                credit += nowCredit;

                switch(temp[2])
                {
                    case "A+": 
                        grade += 4.5 * nowCredit;
                        break;
                    case "A0": 
                        grade += 4.0 * nowCredit;
                        break;
                    case "B+": 
                        grade += 3.5 * nowCredit;
                        break;
                    case "B0": 
                        grade += 3.0 * nowCredit;
                        break;
                    case "C+": 
                        grade += 2.5 * nowCredit;
                        break;
                    case "C0": 
                        grade += 2.0 * nowCredit;
                        break;
                    case "D+": 
                        grade += 1.5 * nowCredit;
                        break;
                    case "D0": 
                        grade += 1.0 * nowCredit;
                        break;
                }
            }

            double result = Math.Round(grade/credit, 6);

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}