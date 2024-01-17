public class Solution 
{
    public int solution(int a, int b, int n) 
    {
        int answer = 0;
        while(n >= a)
        {
            // Exchange bottles
            int exchanged = (n / a) * b;
            // Increase answer
            answer += exchanged;
            // Remaining bottles + new empty bottles
            n = (n % a) + exchanged;
        }
        return answer;
    }
}