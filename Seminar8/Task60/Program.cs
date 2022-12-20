// Задача 60. Сформируйте трёхмерный массив из неповторяющихся (HARD - случайных уникальных) двузначных 
// чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Fill3DArray(int n)
{
    int[,,] array = new int[n, n, n];
    int[] arrayNums = new int[n * n * n];
    int num = 10;

    for (int i = 0; i < arrayNums.Length; i++) //заполняем массив чисел
    {
        arrayNums[i] = num;
        num++;
    }

    for (int i = 0; i < arrayNums.Length; i++) // перемешиваем случайным образом
    {
        int indexRandom = new Random().Next(0, arrayNums.Length);
        int temp = arrayNums[i];
        arrayNums[i] = arrayNums[indexRandom];
        arrayNums[indexRandom] = temp;

    }

    int indexNum = 0;

    for (int i = 0; i < n; i++) // заполняем 3Д-массив
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                array[i, j, k] = arrayNums[indexNum++];
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k],3}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

try
{
    Console.WriteLine("Введите размерность массива");
    int n = Convert.ToInt32(Console.ReadLine());


    int[,,] array = new int[n, n, n];

    if (n * n * n > 99) Console.WriteLine("Слишком большая размерность массива");
    else
    {
        PrintArray(Fill3DArray(n));
        Console.WriteLine();
    }



}

catch
{
    Console.WriteLine("Проверьте правильность ввода данных");
    Console.WriteLine();
}
