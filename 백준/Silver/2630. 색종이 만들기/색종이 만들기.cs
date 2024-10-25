using System.Text;

namespace CodingTest
{
    internal class Program
    {
        static int[,] arr;
        static int whiteCnt = 0;
        static int blueCnt = 0;

        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            // 0이 흰색, 1이 파란색

            int n = int.Parse(sr.ReadLine());

            arr = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = int.Parse(temp[j]);
                }
            }

            Cal(0, 0, n);

            sb.AppendLine(whiteCnt + "\n" + blueCnt);

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static void Cal(int x, int y, int size)
        {
            int baseColor = arr[x, y];

            bool checker = true;

            for (int i = x; i < x + size; i++)
            {
                for (int j = y; j < y + size; j++)
                {
                    if (arr[i, j] != baseColor)
                    {
                        checker = false;
                        break;
                    }
                }
                if (!checker) break;
            }

            if (checker)
            {
                if (baseColor == 0) whiteCnt++;
                else blueCnt++;
                return;
            }

            int newSize = size / 2;
            Cal(x, y, newSize);
            Cal(x + newSize, y, newSize);
            Cal(x, y + newSize, newSize);
            Cal(x + newSize, y + newSize, newSize);

        }
    }
}