using Apps.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.ProblemsSolving
{
  public class Permutations : IApp
  {
    public T Run<T>(T data) where T : class
    {
      HashSet<String> result = new HashSet<string>();
      result.Add(data.ToString());
      GetPermutationList(data.ToString(),0,result);
      StringBuilder res = new StringBuilder();
      int i = 1;
      foreach (var item in result)
      {
        res.Append($"{i++}. {item + Environment.NewLine}");
      }      
      Console.WriteLine(res.ToString());
      return data;
    }

    private void GetPermutationList(string v,int startPosition,HashSet<String> result)
    {      
      for (int z = startPosition; z < v.Length; z++)
      {
        var startPrefix = v.Substring(0, z);
        for (int j = z + 1; j < v.Length; j++)
        {
          var remainingPart = v.Substring(j + 1, v.Length - j - 1);
          var permuatation = startPrefix + v[j] + v.Substring(z + 1, j - (z + 1)) + v[z] + remainingPart;
          if (result.Contains(permuatation))
            throw new FormatException($"dublicate permutation {permuatation}");
          result.Add(permuatation);
          if ( v.Substring(0,z+1) != permuatation.Substring(0,z+1))
            GetPermutationList(permuatation, z + 1, result);              
        }
      }
    }
  }
}
