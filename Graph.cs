using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_C_Sharp
{
    class Graph
    {
        private int[,] list;
        private int n;
        int counter = 0;
        int edges=0;
        public Graph(int n)
        {
            list = new int[n, n];
            this.n = n;
        }

        public Graph(int[,]mass,int edges)
        {
            list = mass;
            this.n = mass.GetLength(0);
            this.edges = edges;
        }

        public void Add(int from,int to, int cost)
        {
            list[from, to] = cost;
        }

        public void DFS(int st, int[] visited)
        {       
            visited[st] = 1;
            counter++;

            for (int i=0;i<n;i++)
            {
                if (list[st,i]==1 && visited[i]==0)
                {
                    DFS(i,visited);
                }
            }           
        }

        public void CheckGraph()
        {
            DFS(0,new int [n]);
            edges /= 2;
            
            if ((edges == n - 1)&&(counter==n))
                Console.WriteLine("The graph is a tree");
            else
                Console.WriteLine("The graph isn't a tree");
        }
    }
}
