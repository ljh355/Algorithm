using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyCompiler {
    class Program {

        static int rows;
        static int cols;
        static bool[,] visited;
        static int[,] grid;
        static int count;

        static void Dfs(int x, int y) {
            // 1. 경계 조건 및 방문 여부, 탐색 조건 확인
            if (x < 0 || x >= rows || y < 0 || y >= cols || visited[x, y] || grid[x, y] == 0) {
                return;
            }
            
            // 2. 현재 노드 방문 처리
            visited[x, y] = true;
            count++;

            // 3. 다음 노드 탐색
            int[] dx = { 0, 0, 1, -1 };
            int[] dy = { 1, -1, 0, 0 };

            for (int i = 0; i < 4; i++) {
                int nx = x + dx[i];
                int ny = y + dy[i];

                Dfs(nx, ny);
            }
        }
        
        public static void Main(string[] args) {
            string firstLine = Console.ReadLine();
            rows = int.Parse(firstLine);
            cols = int.Parse(firstLine);
            grid = new int[rows, cols];
            visited = new bool[rows, cols];

            for (int i = 0; i < rows; i++) {
                string nextLine = Console.ReadLine();
                char[] rowValues = nextLine.ToCharArray();
                for (int j = 0; j < cols; j++) {
                    grid[i, j] = int.Parse(rowValues[j].ToString());
                }
            }

            List<int> complex = new List<int>();

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    if (!visited[i, j] && grid[i, j] == 1) {
                        count = 0;
                        Dfs(i, j);
                        complex.Add(count);
                    }
                }
            }

            complex.Sort();

            Console.WriteLine(complex.Count);
            foreach (int item in complex) {
                Console.WriteLine(item);
            }
        }
    }
}