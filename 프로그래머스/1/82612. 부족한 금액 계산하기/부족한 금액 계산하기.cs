using System;

class Solution {
    public long solution(int price, int money, int count) {
        // 놀이기구를 count번 탈 때 필요한 총 비용 계산
        long totalCost = 0;
        for (int i = 1; i <= count; i++) {
            totalCost += (long)price * i;
        }

        // 현재 가지고 있는 금액에서 필요한 비용을 뺀 값 계산
        long result = totalCost - money;

        // 모자라지 않으면 0을, 모자라면 부족한 금액을 반환
        return Math.Max(0, result);
    }
}