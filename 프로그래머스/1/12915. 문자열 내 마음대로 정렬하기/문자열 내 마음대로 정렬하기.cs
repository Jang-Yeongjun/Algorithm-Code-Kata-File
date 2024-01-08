using System;
using System.Linq;

public class Solution 
{
    public string[] solution(string[] strings, int n) 
    {
        // LINQ을 사용하여 정렬
        var sortedStrings = strings.OrderBy(str => str[n]).ThenBy(str => str).ToArray();
        
        return sortedStrings;
    }
}
