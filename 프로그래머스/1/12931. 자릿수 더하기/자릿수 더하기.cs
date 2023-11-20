using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int numberOfDigits = (int)Math.Floor(Math.Log10(n) + 1);

        for (int i = 0; i < numberOfDigits; i++) {
            answer += (n / (int)Math.Pow(10, i)) % 10;
        }

        return answer;
    }
}