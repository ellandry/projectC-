//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным 
//элементов массива.
double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().NextDouble() * 5;
    return array;
}

void PrintArray(double[] array)
{
    foreach (double el in array) Console.Write("{0,9:N4}", el);
    Console.WriteLine();
}

double MaxEl(double[] array)
{
    double max = array[0];
    foreach (double el in array)
    {
        if (el > max) max = el;
    }
    return max;
}

double MinEl(double[] array)
{
    double min = array[0];
    foreach (double el in array)
    {
        if (el < min) min = el;
    }
    return min;
}

double RaznostMaxmin(double min, double max)
{
    double raznost = max - min;
    return raznost;
}

Console.Write("Введите размерность массива:  ");
int len = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(len);
PrintArray(array);
double razn = RaznostMaxmin(MinEl(array), MaxEl(array));
Console.WriteLine("Разность max и min элементов в массиве равна {0,5:N4}", razn);
Console.WriteLine();
