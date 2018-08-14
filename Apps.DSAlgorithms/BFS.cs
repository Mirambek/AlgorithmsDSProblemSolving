using Apps.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.DSAlgorithms
{
  /// <summary>
  ///     1. Class Graph
  ///     2. add edges
  ///     3. BFS and print
  /// </summary>
  public class BFS : IApp
  {
    public T Run<T>(T data) where T : class
    {
      int numVertex = Convert.ToInt32(4);
      Graph g = new Graph(numVertex);
      g.AddEdge(0, 1);
      g.AddEdge(0, 2);
      g.AddEdge(1, 2);
      g.AddEdge(2, 0);
      g.AddEdge(2, 3);
      g.AddEdge(3, 3);
      g.BFS(0);
      return String.Empty as T;
    }
    class Graph
    {
      public int V { get; }
      public LinkedList<int>[] ArrayAdjecenty { get; }
      public Graph(int vertexs)
      {
        V = vertexs;
        ArrayAdjecenty = new LinkedList<int>[V];
        Initialize();
      }

      private void Initialize()
      {
        for (int i = 0; i < ArrayAdjecenty.Length; i++)
        {
          ArrayAdjecenty[i] = new LinkedList<int>();
        }
      }
      public void BFS(int s)
      {
        if (s >= V)
          throw new IndexOutOfRangeException();
        bool[] visited = new bool[V];
        visited[s] = true;
        Queue<int> visitList = new Queue<int>();
        visitList.Enqueue(s);
        while (visitList.Any())
        {
          var currentVertex = visitList.Dequeue();
          Console.Write($"-> {currentVertex} ");
          foreach (var item in ArrayAdjecenty[currentVertex])
          {
            if (!visited[item])
            {
              visited[item] = true;
              visitList.Enqueue(item);
            }
          }
        }
      }
      public void AddEdge(int v, int u)
      {
        if (v >= V || u >= V)
          throw new IndexOutOfRangeException($"v or u is greater than {V}");
        ArrayAdjecenty[v].AddLast(u);
      }

    }
  }
  
}
