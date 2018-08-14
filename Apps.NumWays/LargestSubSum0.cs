using Apps.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Apps.ProblemsSolving
{
  public class LargestSubSum0 : IApp
  {

    public T Run<T>(T data) where T:class
    {
      var arrays = data.ToString().Split(new char[1] { ' ' },StringSplitOptions.RemoveEmptyEntries);
      Tuple<String, int[]> result = FindLargestSub(arrays.Select(s => Convert.ToInt32(s)).ToArray());
      return result.Item1 as T;
    }

    private Tuple<string, int[]> FindLargestSub(int[] arr)
    {
      IDictionary<int, int> dict = new Dictionary<int, int>();
      int sum = 0;
      int max_len = 0;
      for(int i=0;i<arr.Length;i++)
      {
        sum += arr[i];
        if (arr[i]==0 && max_len == 0)
        {
          max_len = 1;
        }
        if (sum==0)
        {
          max_len = i + 1;
        }
        if (dict.ContainsKey(sum))
        {
          dict.TryGetValue(sum, out int prev_i);
          max_len = Math.Max(max_len, i - prev_i);
        }
        else
          dict.Add(sum, i);
      }
      return Tuple.Create<String, int[]>(max_len.ToString(), dict.Values.Select(s=>s).ToArray());
    }
  }
}
