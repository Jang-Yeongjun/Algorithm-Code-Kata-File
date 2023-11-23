using System;
public class Solution 
{
   public int[] solution(long n) {
        // 입력된 숫자의 자릿수 계산
        int length = (int)Math.Log10(n) + 1;

        // 결과 배열 초기화
        int[] answer = new int[length];

        // 각 자리 숫자를 배열에 저장
        for (int i = 0; i < length; i++) {
            answer[i] = (int)(n % 10);
            n /= 10;
        }

        return answer;
    }
}