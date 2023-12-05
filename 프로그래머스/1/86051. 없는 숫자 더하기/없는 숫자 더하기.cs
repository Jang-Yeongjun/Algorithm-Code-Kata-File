using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] numbers) 
    {
        // 0부터 9까지의 숫자 배열 생성
        int[] allNumbers = Enumerable.Range(0, 10).ToArray();

        // numbers 배열에 있는 숫자들을 제외한 숫자들을 찾아 더함
        int missingSum = allNumbers.Except(numbers).Sum();

        return missingSum;
    }
}