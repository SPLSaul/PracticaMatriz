using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Introduce el nombre del album: ");
            string title = Console.ReadLine();
            Console.Write("Introduce el numero de canciones: ");
            int num = int.Parse(Console.ReadLine());            
            string[,] album = new string[num,2];
            for (int x = 0; x < num; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    Console.Write($"Introduce el nombre de la cancion: ");
                    string nombre = Console.ReadLine();
                    album[x, y] = nombre;
                    y++;
                    Console.Write($"Introduce la duracion de la cancion: ");
                     nombre = Console.ReadLine();
                    album[x, y] = nombre;                   
                }

            }

            Console.WriteLine($"Album: {title}");
            for(int x = 0; x < num; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    Console.Write($"{album[x, y]}                 ");
                    
                }
                Console.WriteLine("");
            }*/
            Console.WriteLine("Matriz #1: ");
            int filas = 4, columnas=4;
            int[,] matriz = new int[filas,columnas];            //Creacion de Matriz 2  
            Random r = new Random();
            for(int i = 0; i < filas; i++)
            {
                for(int j = 0; j < columnas; j++)
                {                   
                    matriz[i, j] = r.Next(0,100);
                }
            }
            for(int i = 0; i < filas; i++)
            {
                for(int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i,j]}  ");
                }
                Console.WriteLine("");
            }
            /*int suma =0;
            for(int i = 0; i < matriz.GetLength(0); i++) //Sumar la primera fila
            {
                suma += matriz[0, i];   //siendo 0 la fila a suma, e i la columna
            }
            Console.WriteLine($"La suma es de fila: {suma}");
            suma = 0;
            for (int i = 0; i < matriz.GetLength(1); i++) //Sumar la primera fila
            {
                suma += matriz[i,0];   //siendo 0 la fila a suma, e i la columna
            }            
            Console.WriteLine($"La suma de columnas es: {suma}");
            suma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++) //Sumar la primera fila
            {
                suma += matriz[i, i];   //siendo 0 la fila a suma, e i la columna
            }
            Console.WriteLine($"La suma de la diagonal: {suma}");
            suma = 0;
            for (int i = 0,j = matriz.GetLength(1)-1; i < matriz.GetLength(0); i++,j--) //Sumar la primera fila
            {
                suma += matriz[i, j];   //siendo 0 la fila a suma, e i la columna
            }
            Console.WriteLine($"La suma de la diagonal inversa: {suma}");*/

            Console.WriteLine("Matriz #2: ");
            int[,] matriz2 = new int[filas, columnas];          //Creacion de Matriz 2  
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz2[i, j] = r.Next(0, 100);
                }
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz2[i, j]}  ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Matriz #3: ");
            int[,] matriz3 = new int[filas, columnas];          //Creacion de Matriz Resultante
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz3[i, j] = matriz[i, j] + matriz2[i, j];
                }
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz3[i, j]}  ");
                }
                Console.WriteLine("");
            }
        }
    }
}
