//Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNumber(int num)
{
    if (num < 0) Console.Write($"{num} отрицательное число");
    if (num == 0) return "";
    if (num == 1) return "1"; //чтобы не выводилась запятая после 1
    return num + ", " + PrintNumber(num - 1);
}

try
{
    Console.WriteLine();
    Console.WriteLine("Введите натуральное число больше 1:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($" {PrintNumber(num)}");
    Console.WriteLine();
}

catch
{
    Console.WriteLine("Проверьте правильность ввода данных");
    Console.WriteLine();
}


