using Apps.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.SortingAlgorithms
{
  public class SortingProblems 
  {
    public T SortSelectedRanges<T>(T data, int i, int j) where T : class
    {
      var givenArray = data as int[];
      int[] arrSorting = (givenArray).Where((a, index) => (index >= i && index <= j)).ToArray();
      int[] left = givenArray.Where((a, index) => (index < i)).ToArray();
      int[] right = givenArray.Where((a, index) => (index > j)).ToArray();
      MergeSortByOption mSorting = new MergeSortByOption(reverseOrdering: true);
      int counter = i;
      var result = mSorting.MergeSort(arrSorting);
      for (int z = 0; z < result.Length; z++)
      {
        givenArray[counter++] = result[z];
      }
      return givenArray as T;
    }    
  }
  class MergeSortByOption
  {
    private readonly bool _reverseOrdering;
    public MergeSortByOption(bool reverseOrdering)
    {
      _reverseOrdering = reverseOrdering;
    }
    public int[] MergeSort(int[] arr)
    {
      if (arr.Length < 2)
        return arr;
      int middle = arr.Length / 2;
      int[] left = MergeSort(arr.Where((a, index) => (index < middle)).ToArray());
      int[] right = MergeSort(arr.Where((a, index) => (index >= middle)).ToArray());
      return Merge(left, right);
    }
    private bool CheckLeftForOrdering(int left,int right)
    {
      return (left < right && !_reverseOrdering) || (left > right && _reverseOrdering);
    }
    /// <summary>
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
      while (resultIdx < result.Length)
      {
        if ((rightIdx >= right.Length)||(leftIdx < left.Length &&  CheckLeftForOrdering(left[leftIdx] , right[rightIdx] )))
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
