using Apps.Common;
using Apps.CSharpFeatures.Evaluation;
using Apps.DSAlgorithms;
using Apps.ProblemsSolving;
using Apps.SortingAlgorithms;
using System;
using System.Linq;

namespace ConsoleApp3
{
  class Program
  {
    static void Main(string[] args)
    {
      EvaluateCSharpFeautures();
      SortingAlgorithms();
      DSAlgorithmsRun();
      ProblemSolvingP1();
    }

    private static void EvaluateCSharpFeautures()
    {
      IApp ptc = new ParallelTaskComparison();
      ptc.Run(String.Empty);
    }

    private static void SortingAlgorithms()
    {
      #region Merge sorting
      MergeSorting ms = new MergeSorting();
      var inputArr = new int[5] { 2, 3, 1, 5, 6 };
      Console.WriteLine("Input Arrays:");
      inputArr.All(a => { Console.Write("{0} ", a); return true; });
      Console.WriteLine();
      Console.WriteLine("Sorted Arrays:");
      foreach (var item in ms.Run<int[]>(inputArr))
      {
        Console.Write("{0} ", item);
      }
      #endregion
    }

    private static void DSAlgorithmsRun()
    {
      #region DFS
      IApp dfs = new DFS();
      dfs.Run<String>(String.Empty);
      #endregion
      #region BFS algorithm
      IApp bfs = new BFS();
      bfs.Run<String>(String.Empty);
      #endregion
    }

    private static void ProblemSolvingP1()
    {
      #region Permutation List
      RunGetPermutationList("12345");
      #endregion
      #region largestSubSum0
      String[] args = new string[1] { "1 1 -1 0" };
      RunLargestSubSum0(args[0]);
      #endregion
      #region runSwapArrayIsEqual
      args = new string[1] { "4,1,2,1,1,112;3,6,3,3" };
      RunSwapArrayIsEqual(args[0]);
      #endregion
      #region RunNumberPossibleMessagesConvertion
      RunNumberPossibleMessagesConvertion("1233");
      #endregion
      #region RunTwoNumUpToK
      RunTwoNumUpToK("10, 15, 3, 1,2,3,4,7", 17);
      #endregion
    }
    #region ContestProblemSolving
    private static void RunGetPermutationList(String args)
    {
      Console.WriteLine($"# Permutation List for {args}");
      IApp l = new Permutations();
      l.Run<String>(args);
      Console.WriteLine($"# Permutation List end!");
    }

    private static void RunLargestSubSum0(String args)
    {
      IApp l = new LargestSubSum0();
      Console.WriteLine(l.Run(args));
    }
    private static void RunSwapArrayIsEqual(String args)
    {
      IApp l = new SwapPairSum();
      Console.WriteLine(l.Run(args));
    }
    private static void RunNumberPossibleMessagesConvertion(String args)
    {
      IApp numWay = new NumWays();
      Console.WriteLine("{0} - numways is :{1}", args, numWay.Run<String>(args));      
    }
    private static void RunTwoNumUpToK(String args,int k)
    {
      IApp twoNumUpToK = new TwoNumUpToK();
      int[] arrays = args.Split(',').Select(s => Convert.ToInt32(s)).ToArray();
      var res=twoNumUpToK.Run<Tuple<int[], int>>(Tuple.Create<int[], int>(arrays, k));
      if (res.Item1 == null)
        Console.WriteLine("Not found!");
      else
        Console.WriteLine("{0}+{1} ={2}", res.Item1[0],res.Item1[1], res.Item2);
    }
    #endregion
  }

}


