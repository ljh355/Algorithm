namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());

            List<Meeting> timeTable = new List<Meeting>();

            for (int i = 0; i < n; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');
                int startTime = int.Parse(temp[0]);
                int endTime = int.Parse(temp[1]);

                timeTable.Add(new Meeting(startTime, endTime));
            }

            List<Meeting> sortedTimeTable = 
                timeTable
                .OrderBy(m => m.EndTime)
                .ThenBy(m => m.StartTime)
                .ToList();

            int cnt = 0;
            int lastEndTime = 0;

            foreach (Meeting meeting in sortedTimeTable)
            {
                if (meeting.StartTime >= lastEndTime)
                {
                    cnt++;
                    lastEndTime = meeting.EndTime;
                }
            }

            sw.Write(cnt);
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        class Meeting
        {
            public int StartTime { get; }
            public int EndTime { get; }

            public Meeting(int startTime, int endTime)
            {
                StartTime = startTime;
                EndTime = endTime;
            }
        }
    }
}