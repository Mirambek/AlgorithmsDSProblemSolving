using Apps.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.SortingAlgorithms
{
  /// <summary>
  /// 1. Sort by halving parts of array until it will be 1 element for each array
  /// 2. Merge back with order
  /// </summary>
  public class MergeSorting : IApp
  {
    public T Run<T>(T data) where T : class
    {
      int[] arr = data as int[];
      return MergeSort(arr) as T;       
    }

    private int[] MergeSort(int[] arr)
    {
      if (arr.Length < 2)
        return arr;
      int middle = arr.Length / 2;
      int[] left = MergeSort(arr.Where(( a, index) => (index < middle)).ToArray());
      int[] right = MergeSort( arr.Where(( a, index) => (index >= middle)).ToArray());
      return Merge(left, right);
      
    }
    /// <summary>
    /// 1. Create temp result array with total of indexes both input arrays
    /// 2. Open loop check both arrays by incrementing index of arrays when lowest compared
    /// 3. return result
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    private int[] Merge(int[] left, int[] right)
    {
      int leftIdx = 0;
      int rightIdx = 0;
      int[] result = new int[left.Length + right.Length];
      int resultIdx = 0;
      while(resultIdx<result.Length)
      {
        if ((leftIdx<left.Length && left[leftIdx]<right[rightIdx]) || (rightIdx>=right.Length))
        {
          result[resultIdx] = left[leftIdx];
          leftIdx++;
        }
        else
        {
          result[resultIdx] = right[rightIdx];
          rightIdx++;
        }
        resultIdx++;
      }
      return result;
    }
  }
}
