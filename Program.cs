using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of edges:");

            int a = Convert.ToInt32(Console.ReadLine());
            int edges = 0;
            int[,] arr = new int[a,a];


            Console.WriteLine();
            Console.WriteLine("Enter the adjacency matrix");

            for (int i=0;i<a;i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                    edges += arr[i,j];
                }
            }

            Graph graph = new Graph(arr,edges);
            graph.CheckGraph();
        }
    }
}
