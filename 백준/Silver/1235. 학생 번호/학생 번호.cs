namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1235

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());

            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = sr.ReadLine();
            }

            int result = 0;

            int numberLength = arr[0].Length;

            for (int i = numberLength - 1; i >= 0; i--)
            {
                HashSet<string> hash = new HashSet<string>();

                for (int j = 0; j < n; j++)
                {
                    if (!hash.Add(arr[j].Substring(i, numberLength - i)))
                    {
                        break;
                    }

                    if (j == n - 1)
                    {
                        result = numberLength - i;
                    }
                }

                if (result == numberLength - i)
                {
                    break;
                }
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}