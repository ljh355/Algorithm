using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodingTest
{
    internal class Program
    {
        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        static void Main()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(sr.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');

                points.Add(new Point(int.Parse(temp[0]), int.Parse(temp[1])));
            }

            points.Sort((point1, point2) =>
            {
                int xCoordinate = point1.X.CompareTo(point2.X);
                if (xCoordinate == 0)
                {
                    return point1.Y.CompareTo(point2.Y);
                }
                return xCoordinate;
            });

            foreach (var point in points)
            {
                sb.AppendLine(point.X.ToString() + " " + point.Y.ToString());
            }

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}