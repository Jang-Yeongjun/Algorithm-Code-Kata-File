using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] numbers) 
    {
        List<int> answerList = new List<int>();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int sum = numbers[i] + numbers[j];
                
                // 중복된 값이 없도록 추가
                if (!answerList.Contains(sum))
                {
                    answerList.Add(sum);
                }
            }
        }

        // 오름차순 정렬
        answerList.Sort();

        // List를 배열로 변환하여 반환
        return answerList.ToArray();
    }
}