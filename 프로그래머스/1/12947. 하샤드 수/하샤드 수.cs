public class Solution
{
    public bool solution(int x)
    {
        int originalNumber = x;
        int addNum = 0;

        while (x > 0)
        {
            addNum += x % 10;
            x /= 10;
        }
        return originalNumber % addNum == 0;
        
    }
}