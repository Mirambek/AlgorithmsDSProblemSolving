using System;
using System.Diagnostics;
using Xunit;

namespace xTestSortingAlgorithms
{
  public class SortingAlgorithms
  {
    [Fact]
    public void PassingSortingByRange()
    {
      var inputArr = new int[5] { 2, 3, 1, 5, 6 };
      #region OrderBy Range Problem using MergeSort
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      SortingProblems sortingProblems = new SortingProblems();
      Debug.WriteLine("Given: {0}", inputArr.ToString());

      int i = 1, j = 3;
      sortingProblems.SortSelectedRanges<int[]>(inputArr, i, j);
      Debug.WriteLine("Sorted: {0} i:{1}, j:{2}", inputArr.ToString(), i, j);
      stopwatch.Stop();
      Debug.WriteLine("RunTime " + stopwatch.ElapsedMilliseconds);
    }
  }
}
