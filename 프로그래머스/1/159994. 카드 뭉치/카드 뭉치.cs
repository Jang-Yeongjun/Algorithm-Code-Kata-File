using System;

public class Solution 
{
    public string solution(string[] cards1, string[] cards2, string[] goal) 
    {
        int index1 = 0, index2 = 0;

        foreach (var word in goal)
        {
            bool found = false;

            // Check if the word is in cards1
            if (index1 < cards1.Length && cards1[index1] == word)
            {
                index1++;
                found = true;
            }
            // If not found in cards1, check cards2
            else if (index2 < cards2.Length && cards2[index2] == word)
            {
                index2++;
                found = true;
            }

            // If the word is not found in both arrays, return "No"
            if (!found) return "No";
        }

        // If all words are found in order, return "Yes"
        return "Yes";
    }
}