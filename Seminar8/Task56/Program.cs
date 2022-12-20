//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 11);
}

int[] RowSum(int[,] array)
{
    int rowSum = 0;
    int[] rowSumArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum = rowSum + array[i, j];
            rowSumArray[i] = rowSum;

        }

        rowSum = 0;

        Console.Write($"{rowSumArray[i],3}\t");
    }

    return rowSumArray;
}

int MinRowSum(int[] array)
{
    int min = array[0];
    int imin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            imin = i;
        }
    }
    return imin;
}

try
{
    Console.WriteLine("Введите количество строк двумерного массива");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов двумерного массива");
    int cols = Convert.ToInt32(Console.ReadLine());
    if (rows == cols)
    {
        Console.WriteLine("Введите разное количество строк и столбцов двумерного массива");
        Console.WriteLine();
    }
    else
    {
        int[,] array = new int[rows, cols];

        FillArray(array);
        PrintArray(array);
        Console.WriteLine();
        int imin = MinRowSum(RowSum(array));
        Console.WriteLine();
        Console.WriteLine($"Номер строки с наименьшей суммой элементов: {imin + 1}-я строка");
        Console.WriteLine();
    }
}

catch
{
    Console.WriteLine("Проверьте правильность ввода данных");
    Console.WriteLine();
}
