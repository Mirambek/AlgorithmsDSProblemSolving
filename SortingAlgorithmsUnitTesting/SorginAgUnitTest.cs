using System;
using System.Diagnostics;
using Apps.SortingAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingAlgorithmsUnitTesting
{
  [TestClass]
  public class SorginAgUnitTest
  {
    [TestMethod]
    public void PassingSortingByRange()
    {
      #region prepare random data
      int n = 1000;
      Random r = new Random();
      var inputArr = new int[n];
      const int min = -10;
      const int max = 10000;
      for (int z=0;z<n;z++)
      {        
        inputArr[z] = r.Next(min, max);
      }
      int i = r.Next(10,400), j = r.Next(400,800);
      #endregion
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      SortingProblems sortingProblems = new SortingProblems();
      Debug.WriteLine("Given: "+String.Join(",", inputArr));

      
      var result= sortingProblems.SortSelectedRanges<int[]>(inputArr, i, j);
      Debug.WriteLine("Sorted: {0} i:{1}, j:{2}",String.Join( ",",result ), i, j);
      stopwatch.Stop();
      Assert.IsTrue(inputArr.Length == result.Length);
      Debug.WriteLine("RunTime " + stopwatch.ElapsedMilliseconds);
    }
  }
}
