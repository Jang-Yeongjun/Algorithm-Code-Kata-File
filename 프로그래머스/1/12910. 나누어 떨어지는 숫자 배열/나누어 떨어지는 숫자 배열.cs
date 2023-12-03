using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] arr, int divisor) 
    {
        // 나누어 떨어지는 값을 저장할 배열
        var result = arr.Where(num => num % divisor == 0).ToArray();
        
        // 나누어 떨어지는 값이 없을 경우 -1을 반환
        if (result.Length == 0) {
            return new int[]{-1};
        }
        
        // 나누어 떨어지는 값들을 오름차순으로 정렬하여 반환
        Array.Sort(result);
        return result;
    }
}
