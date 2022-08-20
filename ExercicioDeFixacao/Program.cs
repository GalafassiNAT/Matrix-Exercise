using System;

namespace ExercicioDeFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the number of lines and columns: ");
            //A vector receives splited data (number of lines and columns respectively).
            string[] lAndC = Console.ReadLine().Split(" ");
            
            int m = int.Parse(lAndC[0]);
            
            int n = int.Parse(lAndC[1]);
          
            int[,] mat = new int[m, n];

            //for that sets the data in the lines.
            for(int i = 0; i < m; i++)
            {
                Console.Write($"Type the numbers({n}) of the line #{i}: ");
                lAndC = Console.ReadLine().Split(" ");

                //for that sets the data in the columns.
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(lAndC[j]);
                }

            }

            Console.Write("Type a number: ");

            //This int will be used to look for an element in the matrix with the same value.
            int element = int.Parse(Console.ReadLine());
            Console.WriteLine();

           //for chain to look for an element in the matrix.
           for(int i = 0; i < m; i++)
            {
                for(int j = 0; j <n; j++)
                {
                    //Checks if the typed number is the same as the Matrix current position.
                    if(mat[i, j] == element)
                    {
                        //Says the position of the element that corresponds to the typed number.
                        Console.WriteLine($"Position: {i}, {j}: ");

                        //These statements will show the numbers arround the typed number (element) in the matrix.
                        if (j > 0)
                        Console.WriteLine($"Left: {mat[i, j - 1]}");
                        if(i > 0)
                        Console.WriteLine($"Up: {mat[i - 1, j]}");
                        if (j < n - 1)
                        Console.WriteLine($"Right: {mat[i, j + 1]}");
                        if (i < m - 1)
                        Console.WriteLine($"Down: {mat[i + 1, j]}");

                    }
                }

            }
        }
    }
}
