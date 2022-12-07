//  Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами 
//в случайном порядке.. Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей 
//то вывести TRUE на экран, иначе вывести False.

int[] FillArray()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write(array[i] + " ");
    }
        return array;
}

int SumOne(int[] array)
{
    int count1 = 0;
    foreach (int el in array)
    {
        if (el == 1) count1++;
    }
    
    return count1;
}

int[] array = FillArray();
int count = SumOne(array);
Console.WriteLine();
Console.WriteLine($"Количество 1 в массиве = {count}");
Console.WriteLine($"Количество 0 в массиве = {8 - count}");

if (count > 8 - count) Console.WriteLine("TRUE");
else if (count < 8 - count) Console.WriteLine("FALSE");
else Console.WriteLine("В массиве равное количество 0 и 1");

Console.WriteLine();

