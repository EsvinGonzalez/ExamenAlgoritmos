using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio4
{
    class Matriz_3x5
    {
        private int[,] mat;

        public void Ingresar()
        {
            mat = new int[3, 5];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write("Ingrese valor de  posicion ["+(f+1)+","+(c+1)+"]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Matriz_3x5 ma = new Matriz_3x5();
            ma.Ingresar();
            ma.Imprimir();
        }
    }
}