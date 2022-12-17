//Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
//и возвращает позицию этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

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

void FindElementArray(int[,] array, int el)
{
    int ifind = -1; 
    int jfind = -1; 
    for (int i=0;i<array.GetLength(0);i++)
       {
        for (int j=0;j<array.GetLength(1);j++) 
             if (array[i,j] == el) 
             {
              ifind = i; 
              jfind = j;  
              Console.WriteLine($"Искомый элемент массива {el} находится на позиции [{ifind},{jfind}]"); 
             }    
       }
    if (ifind == -1) Console.WriteLine($"Искомый элемент {el} в массиве не найден"); 
    if (el < 1 || el > 20) Console.WriteLine("Нужно было ввести целое число от 1 до 20");  
}

try
{
Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число от 1 до 20");
int num = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];
FillArray(array);
PrintArray(array);
Console.WriteLine();
FindElementArray(array, num);
Console.WriteLine();
}

catch
{
Console.WriteLine("Проверьте правильность ввода данных");
Console.WriteLine();
}

