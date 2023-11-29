using System;
using System.Linq;

public class Solution 
{
    public long solution(long n) 
    {
        // 자릿수 계산
        int length = (int)Math.Log10(n) + 1;

        // 각 자릿수를 배열에 저장
        int[] array = new int[length];
        for (int i = 0; i < length; i++) 
        {
            array[i] = (int)(n % 10);
            n /= 10;
        }

        // 배열을 내림차순으로 정렬
        Array.Sort(array, (a, b) => b.CompareTo(a));

        // 정렬된 배열을 이용하여 숫자 조합
        long result = 0;
        for (int i = 0; i < length; i++) 
        {
            result = result * 10 + array[i];
        }

        return result;
    }
}