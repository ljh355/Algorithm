using System;
using System.IO;
using System.Text;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 2885
            // 초콜릿은 막대 모양이고, 각 막대는 정사각형 n개
            // 초콜릿의 크기(정사각형의 개수)는 항상 2의 제곱 형태
            // 상근이는 k개 정사각형을 먹어야 졸지 않는다.
            // k개 정사각형으로 초콜릿 쪼개고 남는 것은 선영이에게
            // 막대 초콜릿은 항상 가운데로만 쪼개져서 d개 있다면 d/2개 두동강
            // k개 정사각형을 만들기 위해 최소 몇 번 초콜릿을 쪼개야하는가
            // 그리고 가장 작은 초콜릿의 크기는 몇인가
            
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            int k = int.Parse(sr.ReadLine());

            int baseChoco = 1;
            int powCnt = 0;
            int cutCnt = 0;

            while (true)
            {
                if (k <= baseChoco)
                {
                    break;
                }
                baseChoco *= 2;
                powCnt++;
            }

            sb.Append(baseChoco + " ");

            while (k > 0)
            {
                if (k >= Math.Pow(2, powCnt))
                {
                    k -= (int)Math.Pow(2, powCnt);
                }

                if (k == 0)
                {
                    break;
                }

                if (k == 1)
                {
                    cutCnt += powCnt;
                    break;
                }
                cutCnt++;
                powCnt--;
            }

            sb.Append(cutCnt);

            sw.Write(sb);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}