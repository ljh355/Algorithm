using System;

public class Solution {
    static int answer = 0;
    
    public int solution(int[] numbers, int target) {
        
        DFS(0, 0, numbers, target);
        
        return answer;
    }
    
    static void DFS(int index, int sum, int[] numbers, int target)
    {
        // 1. 탈출 조건
        if (index == numbers.Length)
        {
            if (sum == target) answer++;
            return;
        }
        
        // 2. 인덱스를 늘릴 때 동작할 DFS, 더하기와 빼기로 구성
        DFS(index+1, sum+numbers[index], numbers, target);
        DFS(index+1, sum-numbers[index], numbers, target);
    }
}