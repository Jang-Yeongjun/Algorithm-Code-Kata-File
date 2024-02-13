using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] answers) 
    {
        int[][] patterns = new int[][] 
        {
            new int[] {1, 2, 3, 4, 5}, // 1번 수포자의 패턴
            new int[] {2, 1, 2, 3, 2, 4, 2, 5}, // 2번 수포자의 패턴
            new int[] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5} // 3번 수포자의 패턴
        };

        int[] score = new int[3]; // 각 수포자의 점수를 저장할 배열

        for (int i = 0; i < answers.Length; i++) 
        {
            for (int j = 0; j < patterns.Length; j++) 
            {
                if (answers[i] == patterns[j][i % patterns[j].Length]) 
                {
                    score[j]++;
                }
            }
        }

        int maxScore = score.Max(); // 가장 높은 점수 찾기
        List<int> winners = new List<int>();
        for (int i = 0; i < score.Length; i++) 
        {
            if (score[i] == maxScore) 
            {
                winners.Add(i + 1); // 인덱스가 0부터 시작하므로 1을 더해줌
            }
        }

        return winners.OrderBy(x => x).ToArray(); // 오름차순 정렬 후 반환
    }
}
