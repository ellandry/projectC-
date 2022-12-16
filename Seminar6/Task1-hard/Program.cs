//задача 1 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n 
//(размерность вводим с клавиатуры). Вывести на экран красивенько таблицей. Найти минимальное 
//число и его индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.
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
            array[i, j] = new Random().Next(-20, 21);
}

void MaxEl(int[,] array)
{
    int max = array[0, 0];
    int imax = 0;
    int jmax = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
                imax = i;
                jmax = j;
            }
        }
    }
    Console.WriteLine($"Максимальный элемент в массиве - [{imax},{jmax}] и равен {max}");    
    Console.WriteLine();
}

void MinEl(int[,] array)
{
    int min = array[0, 0];
    int imin = 0;
    int jmin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                imin = i;
                jmin = j;
            }

        }
    }
    Console.WriteLine($"Минимальный элемент в массиве - [{imin},{jmin}] и равен {min}");
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
MaxEl(array);
MinEl(array);

