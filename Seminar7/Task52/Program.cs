//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
//в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
       {
        for (int j=0;j<array.GetLength(1);j++) 
            Console.Write($"{array[i,j],3}\t");
        Console.WriteLine();
       }
}

void FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
       for (int j=0;j<array.GetLength(1);j++) 
            array[i,j] = new Random().Next(1,21);
}

void SrednArifmetic(int[,] array)
{
    double sumCol = 0; 
     
    for (int j=0;j<array.GetLength(1);j++)
       {
        for (int i=0;i<array.GetLength(0);i++) 
            {
              sumCol = sumCol + array[i,j];
             }    
       Console.Write($"{Math.Round(sumCol / array.GetLength(0), 2),3}\t"); 
       }
    Console.WriteLine();
}

try
{
Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows,cols];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое столбцов");
Console.WriteLine();
SrednArifmetic(array);
Console.WriteLine();
}

catch
{
Console.WriteLine("Проверьте правильность ввода данных");
Console.WriteLine();
}


