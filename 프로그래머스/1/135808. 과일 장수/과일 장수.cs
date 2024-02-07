using System;
using System.Linq;

public class Solution 
{
    public int solution(int k, int m, int[] score) 
    {
        // 사과 점수를 내림차순으로 정렬
        var sortedScore = score.OrderByDescending(s => s).ToArray();
        
        int totalProfit = 0;
        for (int i = 0; i <= sortedScore.Length - m; i += m)
        {
            // 현재 상자에 담긴 사과 중 가장 낮은 점수를 찾음
            int minScore = sortedScore.Skip(i).Take(m).Min();
            // 해당 상자의 가격을 계산하여 총 이익에 추가
            totalProfit += minScore * m;
        }

        return totalProfit;
    }
}
