using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(string[] maps) 
    {
        int[] start = FindPosition(maps, 'S');
        int[] lever = FindPosition(maps, 'L');
        int[] exit = FindPosition(maps, 'E');

        // 시작 지점에서 레버까지의 최단 거리
        int startToLever = BFS(maps, start, lever);
        // 레버에서 출구까지의 최단 거리
        int leverToExit = BFS(maps, lever, exit);

        // 탈출할 수 없는 경우 -1을 반환
        if (startToLever == -1 || leverToExit == -1)
            return -1;

        // 시작 지점에서 출구까지의 최소 시간 계산
        int totalMinTime = startToLever + leverToExit;

        return totalMinTime;
    }

    // 특정 문자의 위치를 찾는 함수
    private int[] FindPosition(string[] maps, char target)
    {
        for (int i = 0; i < maps.Length; i++)
        {
            int index = maps[i].IndexOf(target);
            if (index != -1)
                return new int[] { i, index };
        }

        // 찾지 못한 경우 적절한 예외 또는 기본값 반환
        return new int[] { -1, -1 };
    }

    // BFS를 활용한 최단 거리 계산 함수
    private int BFS(string[] maps, int[] start, int[] target)
    {
        int rows = maps.Length;
        int cols = maps[0].Length;

        int[,] distance = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                distance[i, j] = int.MaxValue;
            }
        }

        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(start);
        distance[start[0], start[1]] = 0;

        int[] dx = { 0, 0, 1, -1 };
        int[] dy = { 1, -1, 0, 0 };

        while (queue.Count > 0)
        {
            int[] current = queue.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int nx = current[0] + dx[i];
                int ny = current[1] + dy[i];

                if (nx >= 0 && nx < rows && ny >= 0 && ny < cols
                    && maps[nx][ny] != 'X' && distance[nx, ny] == int.MaxValue)
                {
                    distance[nx, ny] = distance[current[0], current[1]] + 1;
                    queue.Enqueue(new int[] { nx, ny });

                    // 타겟에 도달한 경우 최단 거리 반환
                    if (nx == target[0] && ny == target[1])
                        return distance[nx, ny];
                }
            }
        }

        // 타겟에 도달할 수 없는 경우 -1 반환
        return -1;
    }
}
