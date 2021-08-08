using System;
using System.IO;
using System.Linq;

namespace BTTuan00_21850025
{
    public class AdjacencyMatrix
    {
        public int N { get; set; }
        public int[,] A { get; set; }

        public void ShowVertex()
        {
            Console.WriteLine("{0}", N);
        }

        public bool ReadAdjacencyMatrix(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("This file does not exist.");
                return false;
            }

            var lines = File.ReadAllLines(fileName);
            if (lines.Length == 0)
            {
                Console.WriteLine("Can't read file.");
                return false;
            }

            N = Int32.Parse(lines.FirstOrDefault() ?? "0");
            A = new int[N, N];
            for (var i = 0; i < N; i++)
            {
                var tokens = lines[i + 1].Split(' ');
                for (var j = 0; j < N; j++)
                    A[i, j] = Int32.Parse(tokens[j]);
            }

            return true;
        }

        public void ShowAdjacencyMatrix()
        {
            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    Console.Write(A[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private void Transpose(int[,] original, int[,] clone)
        {
            if (original?.Length > 0 && clone?.Length > 0)
            {
                for (var i = 0; i < N; i++)
                {
                    for (var j = 0; j < N; j++)
                        clone[i, j] = original[j, i];
                }
            }
        }

        public bool IsSymmetricMatrix()
        {
            var clone = new int[N, N];
            Transpose(A, clone);
            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    if (A[i, j] != clone[i, j])
                        return false;
                }
            }
            return true;
        }
    }
}
