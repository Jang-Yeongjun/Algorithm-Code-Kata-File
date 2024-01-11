using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] array, int[,] commands) 
    {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int[] command = new int[3];
            for (int j = 0; j < 3; j++)
            {
                command[j] = commands[i, j];
            }

            int[] subArray = array.Skip(command[0] - 1).Take(command[1] - command[0] + 1).ToArray();
            Array.Sort(subArray);
            answer[i] = subArray[command[2] - 1];
        }

        return answer;
    }
}