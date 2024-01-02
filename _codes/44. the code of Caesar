public class Solution 
{
    public string solution(string s, int n) 
    {
        char[] charArray = s.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] != ' ')
            {
                char startChar = (char.IsLower(charArray[i])) ? 'a' : 'A';
                charArray[i] = (char)((charArray[i] - startChar + n) % 26 + startChar);
            }
        }

        return new string(charArray);
    }
}
