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

            while(true)
            {
                string input = sr.ReadLine();

                if (input == "0")
                {
                    break;
                }

                char[] inputArr = input.ToCharArray();

                int count = 0;

                for(int i = 0; i < inputArr.Length / 2 + 1; i++)
                {
                    if (inputArr[i] == inputArr[inputArr.Length  - i - 1])
                    {
                        count++;
                    }
                }

                if (inputArr.Length / 2 + 1 == count)
                {
                    sb.AppendLine("yes");
                }
                else
                {
                    sb.AppendLine("no");
                }
            }

            sw.Write(sb + "\n");
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}