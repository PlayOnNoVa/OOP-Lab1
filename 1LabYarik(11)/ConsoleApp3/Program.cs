using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] P = new[,] { { 0, 1, 2, 3, 5 }, { 2, 3, 4, 6, 7 }, { 8, 7, 6, 5, 4 }, { 4, 8, 9, 0, 6 } };
            
            for (int i = 0; i < P.GetLength(0); i++)
            {
                for (int j = 0; j < P.GetLength(1); j++)
                {
                    Console.Write(P[i, j] + "\t");
                }
                Console.WriteLine();

            }
            int[][] Q = new int[P.GetLength(0)][];
            int count = 0;
            for (int i = 0; i < P.GetLength(0); i++)
            {
                Q[i] = new int[0];
                for (int j = 0; j < P.GetLength(1); j++)
                {
                    if (P[i, j] % 2 != 0)
                    {
                        Array.Resize(ref Q[i], Q[i].Length + 1);
                        Q[i][Q[i].Length - 1] = P[i, j];
                        count++;
                    }
                }
            }

            Console.WriteLine(new string('-', 10));
            foreach (int[] m in Q)
                Console.WriteLine(string.Join("\t", m));

            foreach (int[] m in Q)
                Array.Sort(m);

            Console.WriteLine(new string('-', 10));
            foreach (int[] m in Q)
                Console.WriteLine(string.Join("\t", m));

            int[] res = new int[count];
            int index = 0;
            foreach (int[] m in Q)
                foreach (int e in m)
                    res[index++] = e;
            Console.WriteLine(new string('-', 10));
            for (int i = 0; i < res.Length; i++)
                if (res[i] == i) Console.Write(i + "\t");
        }
    }
}
