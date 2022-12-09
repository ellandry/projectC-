//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array) Console.Write($"{el} ");
    Console.WriteLine();
}

int CountChet(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0) count++; 
    }
    return count;
}

Console.WriteLine("Введите размерность массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(len);
PrintArray(array);
Console.WriteLine($"Количество четных элементов массива равно {CountChet(array)}");
Console.WriteLine();
