using System;
using System.Collections.Generic;

public class Solution 
{
    List<int> numbers = new List<int>();
    public int solution(int n) 
    {
      for(int i=1; i<=n; i++)
      {
          if(n%i == 1)
          {
              numbers.Add(i);
          }
      }
        return numbers[0];
    }
}