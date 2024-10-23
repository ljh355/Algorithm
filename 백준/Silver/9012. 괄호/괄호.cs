using System;
using System.Collections.Generic;
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

            int t = int.Parse(sr.ReadLine());

            for(int i=0; i<t; i++)
            {
                Stack<char> stack = new Stack<char>();
                char[] temp = sr.ReadLine().ToCharArray();

                for(int j=0; j<temp.Length; j++)
                {
                    if (stack.Count > 0 && stack.Peek() == '(' && temp[j] == ')')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(temp[j]);
                    }
                }

                if (stack.Count > 0)
                {
                    sb.Append("NO\n");
                }
                else
                {
                    sb.Append("YES\n");
                }
            }

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}