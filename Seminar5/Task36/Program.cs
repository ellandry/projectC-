//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях. [3, 7, 23, 12] -> 19, [-4, -6, 89, 6] -> 0
int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-100, 101);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array) Console.Write($"{el} ");
    Console.WriteLine();
}

int SumNechet(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i]; 
    }
    return sum;
}

Console.WriteLine("Введите размерность массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(len);
PrintArray(array);
Console.WriteLine($"Сумма нечетных элементов массива равна {SumNechet(array)}");
Console.WriteLine();
