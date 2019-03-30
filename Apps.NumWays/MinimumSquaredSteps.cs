using Apps.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.ProblemsSolving
{
 
					
public class MinimumSquaredSteps : IApp
  {
    public T Run<T>(T data) where T : class
    {
      String val = data.ToString();
      return GFG.getMinSquares(Convert.ToInt32(val)).ToString() as T;
    }
  }



   class GFG
  {

    // Returns count of minimum 
    // squares that sum to n 
    public static int getMinSquares(int n)
    {

      // base cases 
      if (n <= 3)
        return n;

      // getMinSquares rest of the 
      // table using recursive 
      // formula 

      // Maximum squares required is 
      // n (1*1 + 1*1 + ..) 
      int res = n;

      // Go through all smaller numbers 
      // to recursively find minimum 
      Console.WriteLine("Beginning n={0} ---------", n);
      for (int x = 1; x <= n; x++)
      {
        int temp = x * x;
        if (temp > n)
          break;
        else
        {
          int squareMinus = getMinSquares(n - temp);
          res = Math.Min(res, 1 + getMinSquares(n - squareMinus));
          Console.WriteLine("n-temp={0}-{1} squareMinus={2} res={3}", n, temp, squareMinus, res);
        }
      }
      Console.WriteLine("Ending n={0}--------------", n);
      Console.WriteLine();
      return res;
    }


  }
}
