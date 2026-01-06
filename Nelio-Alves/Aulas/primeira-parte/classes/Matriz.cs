using System;

namespace CursoCSharp
{
    public class Matriz
    {
        public static void Aula()
        {
            // criação e instanciação de uma matriz
            // dimensão 1 = 2 linhas
            // dimensão 2 = 3 colunas
            double[,] mat = new double[2, 3];

            // Obtém o número total de elementos em todas as dimensões do Array.
            System.Console.WriteLine(mat.Length);

            /* 	
            Obtém a classificação (número de dimensões) do Array. Por exemplo, uma matriz unidimensional retorna 1, 
            uma matriz bidimensional retorna 2 e assim por diante.
            */
            System.Console.WriteLine(mat.Rank);


            /*	
            Obtém um inteiro de 32 bits que representa o número 
            de elementos na dimensão especificada do Array.
            */
            System.Console.WriteLine(mat.GetLength(0));

            System.Console.WriteLine(mat.GetLength(1));
        }

        public static void Exercise1()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            //leitura da matriz
            for (int i = 0; i < n; i++)
            {
                // i faz a leitura da linha
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    // j faz a leitura da coluna
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            System.Console.Write("Main Diagonal: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            System.Console.WriteLine("");

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Negative numbers: {count}");

        }

        public static void Exercise2()
        {
            string[] line = Console.ReadLine().Split(' ');
            int row = int.Parse(line[0]);
            int col = int.Parse(line[1]);

            int[,] mat = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (mat[i, j] == x)
                    {
                        System.Console.WriteLine($"Position: {i},{j}");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < col - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < row - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}