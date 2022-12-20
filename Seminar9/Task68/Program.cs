//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return AkkermanFunc(m - 1, 1);
    else return (AkkermanFunc(m - 1, AkkermanFunc(m, n - 1)));
}

try
{
    Console.WriteLine();
    Console.Write("Введите число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n: ");

    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($"Функция Аккермана при m = {m} и n = {n} равна {AkkermanFunc(m, n)}");
    Console.WriteLine();
}

catch
{
    Console.WriteLine("Проверьте правильность ввода данных");
    Console.WriteLine();
}

