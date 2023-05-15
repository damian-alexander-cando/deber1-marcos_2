using System;

class debermarcos
{
    static void Main()
    {
        Console.Write("Ingrese el numero de filas de la matriz 1: ");
        int filas1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el numero de columnas de la matriz 1: ");
        int columnas1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el numero de filas de la matriz 2: ");
        int filas2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el numero de columnas de la matriz 2: ");
        int columnas2 = Convert.ToInt32(Console.ReadLine());

  

        int[,] matriz1 = PedirDatosMatriz("Ingrese un numero para la matriz 1:", filas1, columnas1);
        int[,] matriz2 = PedirDatosMatriz("Ingrese un numero para la matriz 2:", filas2, columnas2);

        Console.WriteLine("matriz 1:");
        ImprimirMatriz(matriz1);

        Console.WriteLine("matriz 2:");
        ImprimirMatriz(matriz2);

        int[,] matrizSuma = SumarMatrices(matriz1, matriz2);
        Console.WriteLine("matriz suma:");
        ImprimirMatriz(matrizSuma);

        int[,] matrizMultiplicacion = MultiplicarMatrices(matriz1, matriz2);
        Console.WriteLine("matriz multiplicacion:");
        ImprimirMatriz(matrizMultiplicacion);
    }

    static int[,] PedirDatosMatriz(string mensaje, int filas, int columnas)
    {
        Console.WriteLine(mensaje);

        int[,] matriz = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write("Ingrese un numero para la posicion [{i}, {j}]: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        return matriz;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] MultiplicarMatrices(int[,] matriz1, int[,] matriz2)
    {
        int filas1 = matriz1.GetLength(0);
        int columnas1 = matriz1.GetLength(1);
        int columnas2 = matriz2.GetLength(1);

        int[,] matrizMultiplicacion = new int[filas1, columnas2];

        for (int i = 0; i < filas1; i++)
        {
            for (int j = 0; j < columnas2; j++)
            {
                int suma = 0;

                for (int k = 0; k < columnas1; k++)
                {
                    suma += matriz1[i, k] * matriz2[k, j];
                }

                matrizMultiplicacion[i, j] = suma;
            }
        }

        return matrizMultiplicacion;
    }

    static int[,] SumarMatrices(int[,] matriz1, int[,] matriz2)
    {
        int filas = matriz1.GetLength(0);
        int columnas = matriz1.GetLength(1);

        int[,] matrizSuma = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matrizSuma[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        return matrizSuma;
    }
}