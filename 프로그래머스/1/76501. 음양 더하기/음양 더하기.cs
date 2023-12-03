using System;

public class Solution 
{
    public int solution(int[] absolutes, bool[] signs) 
    {
        int answer = 0;

        for (int i = 0; i < absolutes.Length; i++) {
            // signs 배열을 기반으로 각 정수의 부호를 결정하여 더함
            answer += signs[i] ? absolutes[i] : -absolutes[i];
        }

        return answer;
    }
}