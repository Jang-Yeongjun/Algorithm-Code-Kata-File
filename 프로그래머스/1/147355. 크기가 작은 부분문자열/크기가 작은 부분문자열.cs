using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;

        // t의 부분문자열을 순회
        for (int i = 0; i <= t.Length - p.Length; i++) {
            // 부분문자열을 추출
            string subStr = t.Substring(i, p.Length);

            // 부분문자열이 p보다 작거나 같으면 answer 증가
            if (string.Compare(subStr, p) <= 0) {
                answer++;
            }
        }

        return answer;
    }
}
