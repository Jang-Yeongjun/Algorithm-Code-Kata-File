using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int k, int[] score) {
        var hallOfFame = new List<int>();
        var lowestScores = new List<int>();

        foreach (int s in score) {
            hallOfFame.Add(s);
            hallOfFame.Sort();

            // 명예의 전당이 k보다 크면, 가장 낮은 점수를 제거합니다.
            if (hallOfFame.Count > k) {
                hallOfFame.RemoveAt(0);
            }

            // 매일의 최하위 점수를 기록합니다.
            lowestScores.Add(hallOfFame.First());
        }

        return lowestScores.ToArray();
    }
}
