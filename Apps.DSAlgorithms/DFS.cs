using Apps.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.DSAlgorithms
{
  public class DFS : IApp
  {
    public T Run<T>(T data) where T : class
    {
      Graph g = new Graph(4);

      g.AddEdge(0, 1);
      g.AddEdge(0, 2);
      g.AddEdge(1, 2);
      g.AddEdge(2, 0);
      g.AddEdge(2, 3);
      g.AddEdge(3, 3);
      g.DFS(0);
      return data;
    }
    /// <summary>
    /// 1. addEdges
    /// 2. dfs call
    /// 3. it should call recursively DFS
    /// </summary>
    class Graph
    {
      public int V { get; }
      public LinkedList<int>[] ArrayAdjency { get; }
      public Graph(int vertexs)
      {
        V = vertexs;
        ArrayAdjency = new LinkedList<int>[vertexs];
        Initialize();
      }
      private void Initialize()
      {
        for(int i=0;i<V;i++)
        {
          ArrayAdjency[i] = new LinkedList<int>();
        }
      }
      public void AddEdge(int v,int u)
      {
        ArrayAdjency[v].AddLast(u);
      }
      public void DFS(int startingVertex)
      {
        bool[] visited = new bool[V];
        for (int i=0; i < V;i++)
        {
          if (!visited[i])
            DFSTraverse(i, visited);
        }
      }

      private void DFSTraverse(int startingVertex, bool[] visited)
      {
        visited[startingVertex] = true;
        Console.Write("{0} ", startingVertex);
        var vertexAdjacenties = ArrayAdjency[startingVertex];
        foreach (var i in vertexAdjacenties) 
        {
          if (!visited[i])
            DFSTraverse(i, visited);
        }        
      }
    }
  }
}
