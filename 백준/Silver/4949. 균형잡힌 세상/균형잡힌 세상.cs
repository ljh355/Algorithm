using System;
using System.IO;
using System.Collections.Generic;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 4049

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            
            while (true)
            {
                string line = sr.ReadLine();

                if (line == ".")
                {
                    break;
                }

                Stack<char> stack = new Stack<char>();

                foreach (char c in line)
                {
                    if (c == '(' || c == ')' || c == '[' || c == ']' || c == '.')
                    {
                        if (c == '.')
                        {
                            break;
                        }
                        else if (stack.Count > 0 && stack.Peek() == '(' && c == ')')
                        {
                            stack.Pop();
                            continue;
                        }
                        else if (stack.Count > 0 && stack.Peek() == '[' && c == ']')
                        {
                            stack.Pop();
                            continue;
                        }
                        else
                        {
                            stack.Push(c);
                        }
                    }
                }

                if (stack.Count == 0)
                {
                    sw.WriteLine("yes");
                }
                else
                {
                    sw.WriteLine("no");
                }
            }

            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}