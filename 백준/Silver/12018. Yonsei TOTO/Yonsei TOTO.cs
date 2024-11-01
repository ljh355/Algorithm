using System;
using System.IO;
using System.Linq;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 12018
            // 수강신청 마일리지 제도로 바뀌어 과목당 1~36을 분배
            // 마일리지 많이 투자한 순으로 수강인원만큼 신청된다
            // 다른 사람들의 마일리지 투자치를 알 때, 가장 많은 과목 신청하기
            // 마일리지가 같다면 가져갈 수 있음
            
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            // 과목별 배열을 정렬해서 [arr.length-수강인원] 위치의 값만 따로 배열에 저장
            // 해당 배열을 다시 정렬하고, while문을 통해 마일리지 내에서 들을 수 있는 수 체크

            int n = input[0]; // 과목 수
            int m = input[1]; // 주어진 마일리지

            int[] mySubjects = new int[n];
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                // 첫 번째 과목의 입력 5 4 부분에서 끝에 공백 포함으로 오류 발생해서 공백 제거 추가
                int[] firstLine = Array.ConvertAll(sr.ReadLine().Split(' ').Where(s => !string.IsNullOrEmpty(s)).ToArray(), int.Parse);
                int[] secondLine = Array.ConvertAll(sr.ReadLine().Split(' ').Where(s => !string.IsNullOrEmpty(s)).ToArray(), int.Parse);

                Array.Sort(secondLine);

                if (firstLine[0] - firstLine[1] < 0)
                {
                    mySubjects[i] = 1; // 수강 인원이 여유있다면 1만 넣어도 됨
                }
                else
                {
                    mySubjects[i] = secondLine[firstLine[0] - firstLine[1]];
                }
            }

            Array.Sort(mySubjects);

            for (int i = 0; i < mySubjects.Length; i++)
            {
                m -= mySubjects[i];

                if (m < 0)
                {
                    break;
                }

                result++;
            }

            sw.Write(result);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}