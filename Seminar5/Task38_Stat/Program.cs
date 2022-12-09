//Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его 
//индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу 
//в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива.
int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 11);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array) Console.Write($"{el} ");
    Console.WriteLine();
}

int MaxEl(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) 
        {
            max = array[i];
        }
    }
    return max;
}

int IndexMaxEl(int[] array)
{
    int max = array[0];
    int imax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) 
        {
            max = array[i];
            imax = i;
        }
    }
    return imax;
}
int MinEl(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
        }
    }
    return min;
}

int IndexMinEl(int[] array)
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

int SredAr(int[] array)
{
    int sum = 0;
    int srar = 0;
    int leng = array.Length;
    for (int i = 0; i < leng; i++)
    {
        sum += array[i];
    }
    srar = sum / leng;
    return srar;
}

int Median(int[] array)
{
    int medianzn;
    int leng = array.Length;
    int temp;
    for (int i = 0; i < leng - 1; i++)
        for (int j = i + 1; j < leng; j++)
    {
        if (array[i] > array[j]) 
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    
    if (leng % 2 == 0) medianzn = (array[leng/2 - 1] + array[leng/2]) / 2;
    else medianzn = array[leng/2];
    
    return medianzn;
}
Console.Write("Введите размерность массива:  ");

int len = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(len);
Console.WriteLine();
PrintArray(array);

int[] array1 = new int[6];
array1[0] = MaxEl(array);
array1[1] = IndexMaxEl(array);
array1[2] = MinEl(array);
array1[3] = IndexMinEl(array);
array1[4] = SredAr(array);
array1[5] = Median(array);

Console.WriteLine();
Console.WriteLine($"Максимальный элемент массива {array1[0]}, его индекс {array1[1]} ");
Console.WriteLine($"Минимальный элемент массива {array1[2]}, его индекс {array1[3]} ");
Console.WriteLine($"Среднее арифметическое элементов массива {array1[4]} ");
Console.WriteLine($"Медианное значение массива {array1[5]} ");
Console.WriteLine();
Console.Write($"Новый массив: ");
PrintArray(array1);
Console.WriteLine();

