using Apps.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.ProblemsSolving
{
  public class NumWays : IApp
  {
    public T Run<T>(T data) where T : class
    {
      String val = data.ToString();
      return EstimateNumWays(val, val.Length).ToString() as T;
    }

    private int EstimateNumWays(string val, int length)
    {
      if (length == 0)
        return 1;
      int s = val.Length - length;
      if (val[s] == '0')
        return 0;
      var result = EstimateNumWays(val, length - 1);
      if (length >= 2 && Convert.ToInt32(val.Substring(s, 2)) < 27)
        result += EstimateNumWays(val, length - 2);
      return result;      
    }
  }
}
