using System;

public class Solution 
{
    public int solution(int[,] sizes) 
    {
        int maxWidth = 0;
        int maxHeight = 0;

        // 주어진 명함들의 가로 길이와 세로 길이 중에서 최대값을 찾음
        for (int i = 0; i < sizes.GetLength(0); i++) 
        {
            maxWidth = Math.Max(maxWidth, Math.Max(sizes[i, 0], sizes[i, 1]));
            maxHeight = Math.Max(maxHeight, Math.Min(sizes[i, 0], sizes[i, 1]));
        }

        // 최대 가로 길이와 최대 세로 길이를 곱하여 지갑의 크기를 계산
        int answer = maxWidth * maxHeight;
        
        return answer;
    }
}