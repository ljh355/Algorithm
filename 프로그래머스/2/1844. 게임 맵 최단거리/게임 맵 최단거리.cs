using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {
        // 1,1 위치에서 5,5 위치까지 갈 수 있는 가장 빠른 방법
        // 입력은 2차원 배열로 n과 m은 1~100까지의 자연수 [1,1]은 나오지 않음
        // BFS로 숫자를 하나씩 늘려가며 판단
        
        int answer = 0;
        
        int rows = maps.GetLength(0);
        int cols = maps.GetLength(1);
        
        bool[,] visited = new bool[rows, cols];
        
        BFS(0, 0, maps, visited, rows, cols);

        answer = maps[rows-1, cols-1];
        
        if (answer == 1)
        {
            return -1;
        }
        
        return answer;
    }
    
    static void BFS(int x, int y, int[,] maps, bool[,] visited, int rows, int cols)
    {
        // 0. 사방탐색할 dx, dy 정의
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        
        // 1. 큐를 생성
        Queue<(int, int)> q = new Queue<(int, int)>();
        
        // 2. 큐 (x,y) 기준으로 삽입 및 방문 처리
        q.Enqueue((x, y));
        visited[x, y] = true;
        
        // 3. 큐가 빌 때까지 반복
        while(q.Count > 0)
        {
            var (curX, curY) = q.Dequeue();
            
            for (int i=0; i<4; i++)
            {
                int newX = curX + dx[i];
                int newY = curY + dy[i];
                
                if (newX >= 0 && newX < rows && newY >= 0 && newY < cols)
                {
                    if (maps[newX, newY] == 1 && !visited[newX, newY])
                    {
                        q.Enqueue((newX, newY));
                        visited[newX, newY] = true;
                        maps[newX, newY] = maps[curX, curY] + 1;
                    }
                }
            }
        }
    }
}