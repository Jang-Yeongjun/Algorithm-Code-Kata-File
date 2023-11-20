using System;
using System.Linq;

public class Solution 
{
    public double solution(int[] numbers) 
    {
        int sum = 0;
        double answer = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            sum +=numbers[i];
            answer = (double)sum/numbers.Length;
        }
        return answer;
    }
}