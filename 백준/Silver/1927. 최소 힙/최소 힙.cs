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

            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(sr.ReadLine());

                if (temp == 0)
                {
                    if (pq.Count == 0)
                    {
                        sb.AppendLine("0");
                    }
                    else
                    {
                        sb.AppendLine(pq.Dequeue().ToString());
                    }
                }
                else
                {
                    pq.Enqueue(temp, temp);
                }
            }

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}