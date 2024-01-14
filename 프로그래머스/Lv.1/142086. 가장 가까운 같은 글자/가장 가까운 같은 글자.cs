using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string s) 
    {
        int[] answer = new int[s.Length];
        Dictionary<char, int> lastPosition = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) 
        {
            if (lastPosition.ContainsKey(s[i]))
            {
                answer[i] = i - lastPosition[s[i]];
            }
            else
            {
                answer[i] = -1;
            }
            lastPosition[s[i]] = i;
        }

        return answer;
    }
}