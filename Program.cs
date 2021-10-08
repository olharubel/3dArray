using System;
using System.Collections.Generic;

namespace _3dArray
{
    class Program
    {
        static List<int[,]> FindProjections(int[,,] arr3D)
        {
            int m = arr3D.GetLength(0);
            int n = arr3D.GetLength(1);
            int p = arr3D.GetLength(2);

            int[,] arrXY = new int[m, n];
            int[,] arrXZ = new int[m, p];
            int[,] arrYZ = new int[n, p];

            for (int x = 0; x < m; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    for (int z = 0; z < p; z++)
                    {
                        if (arr3D[x, y, 0] == 1)
                            arrXY[x, y] = arr3D[x, y, 0];
                         if (arr3D[x, 0, z] == 1)
                            arrXZ[x, z] = arr3D[x, 0, z];
                         if (arr3D[0, y, z] == 1)
                            arrYZ[y, z] = arr3D[0, y, z];
                    }

                }
            }

            List<int[,]> projections = new List<int[,]>();
            projections.Add(arrXY);
            projections.Add(arrYZ);
            projections.Add(arrXZ);

            return projections;

        }

        static void Print2DArray(int[,] arr2D)
        {
            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    Console.Write(arr2D[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int m = 3;
            int n = 4;
            int p = 2;
            int[,,] arr3D = new int[m, n, p];
            Random random = new Random();

            for (int x = 0; x < m; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    for (int z = 0; z < p; z++)
                    {
                        arr3D[x, y, z] = random.Next(0, 2);
                    }

                }
            }

            List<int[,]> projections = FindProjections(arr3D);

            foreach(var proj in projections){
                Print2DArray(proj);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
