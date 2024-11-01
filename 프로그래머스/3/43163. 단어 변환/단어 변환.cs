using System;

public class Solution {
    static int answer = 0;
    static bool[] visited;
    
    public int solution(string begin, string target, string[] words) {
        visited = new bool[words.Length];
        
        DFS(begin, target, words, 0);
        
        return answer;
    }
    
    static void DFS(string begin, string target, string[] words, int cnt)
    {
        // 1. 종료조건
        if (begin == target)
        {
            answer = cnt;
            return;
        }
        
        // 2. 실행 내역
        for (int i=0; i<words.Length; i++)
        {
            if (visited[i])
            {
                continue;
            }
            
            int anotherCnt = 0;
            
            for (int j=0; j<begin.Length; j++)
            {
                if (begin[j] != words[i][j])
                {
                    anotherCnt++;
                }
            }
            
            if (anotherCnt == 1)
            {
                visited[i] = true;
                DFS(words[i], target, words, cnt + 1);
                visited[i] = false;
            }
        }
    }
}