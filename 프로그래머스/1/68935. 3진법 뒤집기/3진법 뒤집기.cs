using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int n) 
    {
        // n을 3진법으로 변환하고 뒤집음
        List<int> reversedTernaryDigits = ConvertToReversedTernary(n);

        // 뒤집힌 3진법을 10진법으로 변환
        int answer = 0;

        foreach (int digit in reversedTernaryDigits)
        {
            answer = answer * 3 + digit;
        }

        return answer;
    }
    
    // 10진수를 3진법으로 변환하고 뒤집는 함수
    private List<int> ConvertToReversedTernary(int number)
    {
        List<int> result = new List<int>();
        
        while (number > 0)
        {
            int remainder = number % 3;
            result.Add(remainder);
            number /= 3;
        }
        
        return result;
    }
}