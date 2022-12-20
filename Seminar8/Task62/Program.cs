//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
       {
        for (int j=0;j<array.GetLength(1);j++) 
            Console.Write($"{array[i,j],3}\t");
        Console.WriteLine();
       }
}

void FillArray(int[,] array, int n)
{
    int num = 1;
    int i = 0;
    int j = 0;
            
    while (num <= n * n)
     {
        array[i, j] = num;
        if (i <= j + 1 && i + j < n - 1)
        j++;
        else if (i < j && i + j >= n - 1)
        i++;
        else if (i >= j && i + j > n - 1)
        j--;
        else
        i--;
        num++;
     }
}

try
{
Console.WriteLine("Введите размерность массива");
    int n = Convert.ToInt32(Console.ReadLine());


int[,] array = new int [n,n];
FillArray(array, n);
PrintArray(array);
Console.WriteLine();

}

catch
{
Console.WriteLine("Проверьте правильность ввода данных");
Console.WriteLine();
}



