using Apps.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.ProblemsSolving
{
  public class MinimumRootSquare : IApp
  {
    public T Run<T>(T data) where T : class
    {
      int n = (int)(data as int?);
      ExtracterMinimumRootSquare emr = new ExtracterMinimumRootSquare();
      return emr.Extract(n) as T;
    }
  }

  internal class ExtracterMinimumRootSquare
  {
    internal int? Extract(int n)
    {

      // We need to add a check here for n. If user enters 0 or 1 or 2  
      // the below array creation will go OutOfBounds. 

      if (n <= 3)
        return n;

      // Create a dynamic programming 
      // table to store sq 
      int[] dp = new int[n + 1];

      // getMinSquares table for base 
      // case entries 
      dp[0] = 0;
      dp[1] = 1;
      dp[2] = 2;
      dp[3] = 3;

      // getMinSquares for rest of the   
      // table using recursive formula 
      for (int i = 4; i <= n; i++)
      {
        // max value is i as i can  
        // always be represented  
        // as 1 * 1 + 1 * 1 + ... 
        dp[i] = i;

        // Go through all smaller numbers to 
        // to recursively find minimum 
        for (int x = 1; x <= i; x++)
        {
          int temp = x * x;
          if (temp > i)
            break;
          else dp[i] = Math.Min(dp[i], 1 +
                                dp[i - temp]);
        }
      }

      // Store result and free dp[] 
      int res = dp[n];

      return res;
    }
  }
}
