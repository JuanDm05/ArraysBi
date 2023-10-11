using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysBi
{
    internal class Metodos
    {
        public void ExtraClase1()
        {
            int[] arreglo1 = new int[15];
            int[] arreglo2 = new int[20];

            // Llenar arreglo1 con múltiplos de 5
            for (int i = 0, valor = 5; i < 15; ++i, valor += 5)
            {
                arreglo1[i] = valor;
            }

             for (int i = 0; i < 20; ++i)
            {
                arreglo2[i] = i + 1; 
            }

            // Copiar los últimos 10 elementos de arreglo1 en los últimos 10 elementos de arreglo2
            Array.Copy(arreglo1, 5, arreglo2, 10, 10);

            // Imprimir arreglo1 y arreglo2
            Console.WriteLine("Elementos del arreglo 1:");
            Console.WriteLine(string.Join(",", arreglo1));

            Console.WriteLine("Elementos del arreglo 2:");
            Console.WriteLine(string.Join(",", arreglo2));
        }
        public void Matriz()
        {
            Console.WriteLine("Ingrese el número de filas de la matriz:");
            int filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz:");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            // Solicitar al usuario que ingrese valores en la matriz
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Visualizar los valores ingresados en la matriz
            Console.WriteLine("Valores ingresados en la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] +"    ");
                }
                Console.WriteLine();
            }
        }
        public void Matriz3x3()
        {
            int[,] matricula = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Matriz 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matricula[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Colores()
        {
            string[,] color = new string[2, 2] { { "Rojo", "Verde" }, { "Azul", "Amarillo" } };

            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 2; columna++)
                {
                    Console.WriteLine($"{color[fila, columna]}");
                }
                Console.WriteLine();
            }
        }
        public void SumaMatriz()
        {
            double[,] matriz = new double[4, 3] { {2.5,2.2,2.1},{5.5,5.2,4.2 },{23,23,23 },{12,12,1.2 }};
            double suma = 0;
            for (int fila = 0;fila < 4; fila++)
            {
                for(int columna = 0;columna < 3; columna++)
                {
                    Console.WriteLine(matriz[fila, columna] + " ");
                    suma += matriz[fila, columna];
                }
                Console.WriteLine( "la suma de esta matrtiz es "+ suma);
            }

      }
        public void alfabetico()
        {
            char[,] letras = new char[2, 4] { { 'A', 'B', 'C', 'D' }, { 'E', 'F', 'G', 'H' } };
            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    Console.Write(letras[fila, columna]+ "   ");
                }
                Console.WriteLine();
            }
        }
    }

}