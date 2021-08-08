using System;
using System.IO;

namespace BTTuan00_21850025
{
    class Program
    {
        static void Main(string[] args)
        {
            Cau1();
        }

        public static void Cau1()
        {
            Console.WriteLine("*-----------*");
            Console.WriteLine("Cau 1:");
            string currentPath = Directory.GetCurrentDirectory();
            string _filePath = Directory.GetParent(
                    Directory.GetParent(
                        Directory.GetParent(
                            Directory.GetParent(currentPath)
                            .FullName)
                        .FullName)
                    .FullName
                )
                .FullName
                ;
            _filePath += "/static/adjacency-matrix.txt";

            var am = new AdjacencyMatrix();
            am.ReadAdjacencyMatrix(_filePath);
            am.ShowVertex();
            am.ShowAdjacencyMatrix();
            var isSymmetric = am.IsSymmetricMatrix();
            if (isSymmetric)
                Console.WriteLine("Ma tran doi xung");
            else
                Console.WriteLine("Ma tran khong doi xung");
        }
    }
}
