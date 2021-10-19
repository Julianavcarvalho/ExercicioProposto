using System;

namespace ExercicioProposto {
    class Program {
        static void Main(string[] args) {


            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);


            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] == 0) {
                        do {
                            mat[i - 1, j - 1] = 0;
                        } while (i >= mat[0, 0]);
                        do {
                            mat[i + 1, j + 1] = 0;
                        } while (i <= mat.Length);
                    }
            }

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
