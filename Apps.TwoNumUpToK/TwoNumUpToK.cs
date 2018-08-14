using Apps.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.TwoNumUpToK
{
  public class TwoNumUpToK : IApp
  {
    public T Run<T>(T data) where T : class
    {
      Tuple<int[], int> val = data as Tuple<int[], int>;
      HashSet<int> mem = new HashSet<int>();
      int k = val.Item2;
      foreach(var item in val.Item1)
      {
        var difference = k - item;
        if (mem.Contains(difference))
          return Tuple.Create<int[], int>(new int[2] { item, difference },k) as T;
        mem.Add(item);
      }
      return Tuple.Create<int[], int>(null, k) as T; ;      
    }
  }
}
