using System;
using System.Collections.Generic;

namespace CodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // N : 저장된 사이트의 주소 수
            // M : 비밀번호 찾으려는 사이트 주소 수
            // N개의 수만큼 '주소 패스워드' 형태의 입력이 들어온다.
            // M개의 수만큼 '주소'만 들어올 때, 해당 주소의 패스워드를 출력한다.
            // 저장된 주소를 Dictionary를 이용해 key, value로 저장
            // 저장한 값을 바탕으로 TryGetValue를 통해 찾는 주소와 일치하면 Value인 패스워드 출력

            string fristLine = Console.ReadLine();
            string[] firstLineParts = fristLine.Split(' ');

            int N = int.Parse(firstLineParts[0]);
            int M = int.Parse(firstLineParts[1]);

            Dictionary<string, string> siteDic = new Dictionary<string, string>();

            for (int i = 0; i < N; i++)
            {
                string siteLine = Console.ReadLine();
                string[] siteLineParts = siteLine.Split(' ');

                siteDic.Add(siteLineParts[0], siteLineParts[1]);                
            }

            for (int i = 0; i < M; i++)
            {
                string findSite = Console.ReadLine();

                if (siteDic.TryGetValue(findSite, out string sitePassword))
                {
                    Console.WriteLine(sitePassword);
                }
                else
                {
                    Console.WriteLine("저장된 사이트 내에 찾는 사이트 주소가 없습니다.");
                }
            }

        }
    }
}
