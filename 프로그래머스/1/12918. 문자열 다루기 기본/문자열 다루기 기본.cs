using System;

public class Solution 
{
    public bool solution(string s) 
    {
        // 문자열 길이가 4 또는 6이 아니면 false 반환
        if (s.Length != 4 && s.Length != 6)
        {
            return false;
        }

        // 문자열의 각 문자가 숫자인지 확인
        foreach (char c in s)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        // 모든 조건을 만족하면 true 반환
        return true;
    }
}