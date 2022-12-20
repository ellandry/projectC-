//ЗЗадача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух 
// матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],3}\t");
        Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 4);
}

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2, int n)
{
    int[,] resMatrix = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                resMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resMatrix;
}

try
{
    Console.WriteLine("Введите размерность матриц");
    int n = Convert.ToInt32(Console.ReadLine());


    int[,] matrix1 = new int[n, n];
    int[,] matrix2 = new int[n, n];
    FillArray(matrix1);
    PrintArray(matrix1);
    Console.WriteLine();
    FillArray(matrix2);
    PrintArray(matrix2);
    Console.WriteLine();
    Console.WriteLine("Произведение двух матриц равно:");
    Console.WriteLine();
    PrintArray(MatrixProduct(matrix1, matrix2, n));
    Console.WriteLine();
}

catch
{
    Console.WriteLine("Проверьте правильность ввода данных");
    Console.WriteLine();
}



