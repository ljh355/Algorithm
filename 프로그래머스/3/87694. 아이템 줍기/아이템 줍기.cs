using System;
using System.Collections.Generic;

public class Solution {
    static int[,] board = new int[102, 102];
    static bool[,] visited = new bool[102, 102];
    
    public int solution(int[,] rectangle, int characterX, int characterY, int itemX, int itemY) {
        int answer = 0;
        
        CheckRectangle(rectangle);
        
        BFS(characterX*2, characterY*2);
        
        answer = board[itemX*2, itemY*2]/2;

        return answer;
    }
    
    static void BFS(int startX, int startY)
    {
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        Queue<(int, int)> q = new Queue<(int, int)>();
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);
        
        visited[startX, startY] = true;
        q.Enqueue((startX, startY));
        
        while(q.Count > 0)
        {
            var (curX, curY) = q.Dequeue();
            
            for (int i=0; i<4; i++)
            {
                int newX = curX + dx[i];
                int newY = curY + dy[i];
                
                if (newX >= 0 && newX < rows && newY >= 0 && newY < cols)
                {
                    if (board[newX, newY] == 1 && !visited[newX, newY])
                    {
                        q.Enqueue((newX, newY));
                        visited[newX, newY] = true;
                        board[newX, newY] = board[curX, curY] + 1;
                    }
                }
            }
        }
    }
    
    static void CheckRectangle(int[,] rectangle)
    {
        for (int i=0; i<rectangle.GetLength(0); i++)
        {
            for (int a=rectangle[i,0]*2; a<=rectangle[i,2]*2; a++)
            {
                for (int b=rectangle[i,1]*2; b<=rectangle[i,3]*2; b++)
                {
                    board[a,b] = 1;
                }
            }
        }
        
        for (int i=0; i<rectangle.GetLength(0); i++)
        {
            for (int a=rectangle[i,0]*2+1; a<=rectangle[i,2]*2-1; a++)
            {
                for (int b=rectangle[i,1]*2+1; b<=rectangle[i,3]*2-1; b++)
                {
                    board[a,b] = 0;
                }
            }
        }
    }
}