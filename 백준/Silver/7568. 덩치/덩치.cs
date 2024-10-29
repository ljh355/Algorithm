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

            int n = int.Parse(sr.ReadLine());

            int[] cm = new int[n];
            int[] kg = new int[n];
            int[] cnt = new int[n];

            for (int i=0; i<n; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');
                cm[i] = int.Parse(temp[0]);
                kg[i] = int.Parse(temp[1]);
            }

            for (int i=0; i<n;i++)
            {
                for (int j=i+1; j<n; j++)
                {
                    if (cm[i] > cm[j] && kg[i] > kg[j])
                    {
                        cnt[j]++;
                    }
                    else if ((cm[i] < cm[j] && kg[i] < kg[j]))
                    {
                        cnt[i]++;
                    }
                }
            }

            for (int i = 0; i < cnt.Length; i++)
            {
                sb.Append(++cnt[i]+" ");
            }

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}