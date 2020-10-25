using System;

namespace VogelMultiplicadores
{
    class Program
    {
        static int Menor(int a, int b)
        {
            int menor = b;
            if (a < b)
            
                menor = a;
                return menor;
            
        }

        public static int[,] sortArrayBidi(int a, int b, int[,] originArray)
        {
            // Creamos un array temporal para almacenar el valor anterior
            // para no perder el valor
            int[,] tmp = new int[a, b];
            // Recorremos el array entero
            for (int i = 0; i < (originArray.Length / 2); i++)
            {
                // Para cada valor de "i" recorremos el array entero
                for (int j = 0; j < (originArray.Length / 2) - 1; j++)
                {
                    if (originArray[j, 0] < originArray[j + 1, 0])
                    {
                        // Cogemos el valor actual y lo ponemos en el array temporal
                        tmp[0, 0] = originArray[j, 0];
                        tmp[0, 1] = originArray[j, 1];
                        // Reemplazamos el valor del array por el siguiente valor
                        originArray[j, 0] = originArray[j + 1, 0];
                        originArray[j, 1] = originArray[j + 1, 1];
                        // En el siguente valor, ponemos el temporal
                        originArray[j + 1, 0] = tmp[0, 0];
                        originArray[j + 1, 1] = tmp[0, 1];
                    }
                }
            }
            return tmp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de origenes: ");
            var origen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de destinos: ");
            var destinos = Convert.ToInt32(Console.ReadLine());
            int filas = origen + 1;
            int columnas = destinos + 1;
            int[,] matrizMadre = new int[filas, columnas];
            Menor(filas,columnas);
            Console.WriteLine("--------Datos--------");
            for (int i = 0; i < filas; i++)
            {
                if (i == filas - 1)
                {
                    for (int j = 0; j < columnas; j++)
                    {

                        if (j == columnas - 1)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("Ingrese demanda origen " + j + ": ");
                            var leer = Convert.ToInt32(Console.ReadLine());
                            matrizMadre[i, j] = leer;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (j == columnas - 1)
                        {
                            Console.Write("Ingrese Oferta destino " + i + ": ");
                            var leer = Convert.ToInt32(Console.ReadLine());
                            matrizMadre[i, j] = leer;
                        }
                        else
                        {
                            Console.Write("Ingrese costo de destino " + i + " origen " + j + ": ");
                            var leer = Convert.ToInt32(Console.ReadLine());
                            matrizMadre[i, j] = leer;
                        }
                    }
                }
                Console.WriteLine("");
            }
            //Clear SCREEN
            Console.Clear();
            Console.WriteLine("--------Render Datos-------");
            for (int i = 0; i < filas; i++)
            {
                if (i == filas - 1)
                {
                    for (int j = 0; j < columnas; j++)
                    {

                        if (j == columnas - 1)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            //Demanda
                            Console.Write("[" + matrizMadre[i, j] + "]");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (j == columnas - 1)
                        {
                            //OFERTA
                            Console.Write("[" + matrizMadre[i, j] + "]");
                        }
                        else
                        {
                            Console.Write("[" + matrizMadre[i, j] + "]");
                        }
                    }
                    Console.WriteLine("");
                }

            }

            int contadorFilas=0;
            int contadorCol=0;

            for(int i = 0; i < filas - 1; i++)
            { 
                for (int j = 0; j < columnas - 1; j++)
                {
                    contadorCol++;
                }
                contadorFilas++;
            }

            int[,] temp = new int[contadorFilas, contadorCol];

            for (int i = 0; i < filas - 1; i++)
            {
                for (int j = 0; j < columnas - 1; j++)
                {
                    temp[i, j] = matrizMadre[i, j];
                }
            }

            int[] penalizacionColumna = new int[contadorFilas];
            int[] penalizacionFila = new int[contadorCol];

            //sortArrayBidi(contadorFilas,contadorCol, temp);
            Console.WriteLine("");
            Console.WriteLine("Datos filtrados");
            for (int i = 0; i < filas - 1; i++)
            {
                for (int j = 0; j < columnas - 1; j++)
                {
                    Console.Write("[" + temp[i, j] + "]");
                }
                Console.WriteLine("");
            }


           
        }
    }
}
