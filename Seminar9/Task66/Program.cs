// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumberSumm(int M, int N, int sum)
{
    if (M > N) return sum;
    else
    {
        sum += M;
        return NumberSumm(M + 1, N, sum);
    }
}

try
{
    Console.WriteLine();
    Console.Write("Введите целое число M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    Console.WriteLine();
    Console.WriteLine($"M={M}; N={N} -> {NumberSumm(M, N, sum)}");
    Console.WriteLine();
}

catch
{
    Console.WriteLine("Проверьте правильность ввода данных");
    Console.WriteLine();
}


