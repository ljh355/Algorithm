using System;
using System.Collections.Generic;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 2891
            // 카약 대회에서 강풍이 불어 카약이 부서졌다.
            // 자신의 전이나 다음 팀에게만 카약을 빌려줄 수 있다.
            // 다른 팀에게 받는 카약은 빌려줄 수 없다.
            // ! 이게 아님 -> 가져온 팀은 빌려줄 경우,여분의 카약으로 출전하기에 빌려줄 수 없다.
            // ! 이게 맞음 -> 카약을 하나 더 가져온 팀의 카약이 손상됐다면 못 빌려준다. 
            // 출발을 할 수 없는 팀의 최솟값 출력
            // 배열을 하나 만들어 왼쪽부터 좌우 인덱스를 검사해서 바꿔주는 방식으로 체크
            // -1: 손상된 팀, 0: 일반 팀, 1: 카약을 하나 더 가져온 팀

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] firstLine = sr.ReadLine().Split(' ');
            string[] secondLine = sr.ReadLine().Split(' ');
            string[] thirdLine = sr.ReadLine().Split(' ');

            int n = int.Parse(firstLine[0]); // 팀의 수
            int s = int.Parse(firstLine[1]); // 카약이 손상된 팀의 수
            int r = int.Parse(firstLine[2]); // 카약을 하나 더 가져온 팀의 수
            int[] breakTeamNum = Array.ConvertAll(secondLine, int.Parse); // 카약이 손상된 팀 번호
            int[] spareTeamNum = Array.ConvertAll(thirdLine, int.Parse); // 카약을 하나 더 가져온 팀 번호

            int[] allTeam = new int[n+2]; // 앞뒤로 인덱스 체크 예외처리 안하기 위해
            int cnt = 0;

            for (int i = 0; i < spareTeamNum.Length; i++)
            {
                allTeam[spareTeamNum[i]] = 1;
            }

            // 하나 더 가져온 팀을 먼저 놓고, 여기서 조건문으로 검증
            for (int i = 0; i < breakTeamNum.Length; i++)
            {
                if (allTeam[breakTeamNum[i]] == 1)
                {
                    allTeam[breakTeamNum[i]] = 0;
                }
                else
                {
                    allTeam[breakTeamNum[i]] = -1;
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (allTeam[i] == 1 && allTeam[i-1] == -1)
                {
                    allTeam[i - 1] = 0;
                    allTeam[i] = 0;
                }
                else if (allTeam[i] == 1 && allTeam[i+1] == -1)
                {
                    allTeam[i + 1] = 0;
                    allTeam[i] = 0;
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (allTeam[i] == -1)
                {
                    cnt++;
                }
            }
                
            sw.Write(cnt);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}