using Apps.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.ProblemsSolving
{
  public class SwapPairSum : IApp
  {
    public T Run<T>(T data) where T : class
    {
      String result = String.Empty;
      var inputData = data.ToString();
      if (String.IsNullOrEmpty(inputData))
      for (int i = 0; i < (new Random()).Next(1, 2); i++)
      {
        int sampleSize = (new Random()).Next(3, 7);
        int[] arr1 = GetArraySampleInt(sampleSize);
        int[] arr2 = GetArraySampleInt(sampleSize);
        result += $"arr1={String.Join(",",arr1)} arr2={String.Join(",",arr2)} result={CheckSumEqual(arr1, arr2)}";
      }
      else
      {
        var inputs=inputData.Split(';');
        int[] arr1 =inputs[0].Split(',').Select(s=>Convert.ToInt32(s)).ToArray() ;
        int[] arr2 = inputs[1].Split(',').Select(s => Convert.ToInt32(s)).ToArray();
        result += $"arr1={String.Join(",", arr1)} arr2={String.Join(",", arr2)} result={CheckSumEqual(arr1, arr2)}";
      }
      return  result as T;
    }

    private String CheckSumEqual(int[] arr1, int[] arr2)
    {
      HashSet<int> arr1Dict = new HashSet<int>();
      HashSet<int> arr2Dict = new HashSet<int>();
      int arr1Sum= 0;
      foreach(var z in arr1)
      {
        arr1Sum += z;
        arr1Dict.Add(z);
      }
      int arr2Sum = 0;
      foreach (var z in arr2)
      {
        arr2Sum += z;
        arr2Dict.Add(z);
      }
      int diff = Math.Abs(arr1Sum - arr2Sum);
      const String isEqual= "1";
      const String isNotEqual = "-1";
      if (diff == 0)
        return isEqual;
      foreach(var z in arr1Dict)
      {
        if (arr2Dict.Contains(Math.Abs(z- diff)))
          return isEqual;
      }
      return isNotEqual;
    }
    Random r = new Random();
    private int[] GetArraySampleInt(int sampleSize)
    {
      int[] res = new int[sampleSize];
      
      for (int i=0;i<sampleSize;i++)
      {
        res[i] = r.Next(0,20);
      }
      return res;
    }
  }
}
