using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        // 배열이 비어있는 경우 -1을 채워 리턴
        if (arr.Length <= 1) {
            return new int[]{-1};
        }

        // 가장 작은 수 찾기
        int min = arr.Min();

        // 가장 작은 수를 제외한 새로운 배열 생성
        int[] answer = arr.Where(num => num != min).ToArray();

        return answer;
    }
}