using Apps.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.CSharpFeatures.Evaluation
{
  public class ParallelTaskComparison : IApp
  {
    public T Run<T>(T data) where T : class
    {
      DateTime startTime = DateTime.Now;
      int totalNumber = 1000;
      Parallel.For(0, totalNumber, i =>
        {
          RecursiveRandomFunction(i);
        });
      Console.WriteLine();
      String result1=String.Format("For parallel took ms {0}", (DateTime.Now - startTime).TotalMilliseconds);
      startTime = DateTime.Now;
      for (int i = 0; i < totalNumber; i++)
      {
        RecursiveRandomFunction(i);
      }
      Console.WriteLine(result1);
      Console.WriteLine("Simple for took ms {0}", (DateTime.Now - startTime).TotalMilliseconds);
      return data;
    }
    private int RecursiveRandomFunction(int z)
    {
      z = z - 1;
      Console.WriteLine("Current z is {0}", z);
      if (z > 0)
        z=RecursiveRandomFunction(z);
      return z;
    }
  }
}
