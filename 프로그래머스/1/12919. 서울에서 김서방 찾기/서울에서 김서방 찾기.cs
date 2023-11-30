using System;

public class Solution {
    public string solution(string[] seoul) {
        int num = -1; // Initialize to -1
        for (int i = 0; i < seoul.Length; i++) {
            if (seoul[i].Equals("Kim")) {
                num = i; // Set num to the current index if "Kim" is found and exit the loop
                break;
            }
        }

        string answer = (num != -1) ? $"김서방은 {num}에 있다" : "김서방은 없다";
        return answer;
    }
}