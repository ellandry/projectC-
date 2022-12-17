//Задача 52. Задайте двумерный массив из целых чисел. Количество строк и столбцов 
//задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

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
            array[i, j] = new Random().Next(1, 21);
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(0); k++)
            {
                for (int l = 0; l < array.GetLength(1); l++)
                {
                    if (array[k, l] > array[i, j]) (array[k, l], array[i, j]) = (array[i, j], array[k, l]);
                }
            }
        }
    }
}

try
{
    Console.WriteLine("Введите количество строк двумерного массива");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов двумерного массива");
    int cols = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, cols];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine("Массив после сортировки");
    Console.WriteLine();
    SortArray(array);
    PrintArray(array);
    Console.WriteLine();
}

catch
{
    Console.WriteLine("Проверьте правильность ввода данных");
    Console.WriteLine();
}



