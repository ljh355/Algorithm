namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int m = int.Parse(sr.ReadLine());

            int result = 1;

            for (int i = 0; i < m; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');
                int x = int.Parse(temp[0]);
                int y = int.Parse(temp[1]);

                if (result == x)
                {
                    result = y;
                }
                else if (result == y)
                {
                    result = x;
                }
            }
            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}