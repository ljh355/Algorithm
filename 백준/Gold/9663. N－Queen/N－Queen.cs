namespace CodingTest
{
    internal class Program
    {
        static int N;
        static int[] v1, v2, v3;
        static int cnt = 0;
        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            N = int.Parse(sr.ReadLine());

            v1 = new int[N];
            v2 = new int[2 * N];
            v3 = new int[2 * N];

            DFS(0);

            sw.Write(cnt);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static void DFS(int row)
        {
            if (row == N)
            {
                cnt += 1;
                return;
            }

            for (int i = 0; i < N; i++)
            {
                if (v1[i] == 0 && v2[row + i] == 0 && v3[row - i + N] == 0)
                {
                    v1[i] = v2[row + i] = v3[row - i + N] = 1;
                    DFS(row + 1);
                    v1[i] = v2[row + i] = v3[row - i + N] = 0;
                }
            }
        }
    }
}