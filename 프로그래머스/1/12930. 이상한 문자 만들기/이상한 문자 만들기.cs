public class Solution {
    public string solution(string s) {
        string[] words = s.Split(' '); // 공백을 기준으로 단어로 나눔
        string answer = "";

        foreach (string word in words) {
            for (int i = 0; i < word.Length; i++) {
                // 각 단어의 홀수번째 알파벳은 대문자로, 짝수번째 알파벳은 소문자로 변환
                if (i % 2 == 0) {
                    answer += char.ToUpper(word[i]);
                } else {
                    answer += char.ToLower(word[i]);
                }
            }
            answer += " "; // 단어 사이에 공백 추가
        }

        // 마지막에 추가된 공백 제거
        if (answer.Length > 0) {
            answer = answer.Remove(answer.Length - 1); // 마지막에 추가된 공백 제거
        }

        return answer;
    }
}