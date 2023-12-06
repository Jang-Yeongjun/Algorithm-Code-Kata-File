public class Solution 
{
    public string solution(string s) 
    {
        int length = s.Length;

        if (length % 2 == 1) 
        {
            int middleIndex = length / 2;
            return s[middleIndex].ToString();
        }
        else 
        {
            int middleIndex = length / 2 - 1;
            return s.Substring(middleIndex, 2);
        }
    }
}