using System;
using System.Text;

public class Solution 
{
    public string solution(int[] food) 
    {
        StringBuilder answer = new StringBuilder();
        int n = food.Length;
        int[] half = new int[n]; // To store half of the food items

        // Calculate half of each food item, rounding down for odd numbers
        for (int i = 1; i < n; i++) 
        {
            half[i] = food[i] / 2;
        }

        // Construct the first half of the string
        for (int i = 1; i < n; i++) 
        {
            for (int j = 0; j < half[i]; j++) 
            {
                answer.Append(i.ToString());
            }
        }

        // Add the water in the middle
        answer.Append("0");

        // Construct the second half of the string (mirror the first half)
        for (int i = n - 1; i >= 1; i--) 
        {
            for (int j = 0; j < half[i]; j++) 
            {
                answer.Append(i.ToString());
            }
        }

        return answer.ToString();
    }
}