//Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 | num > 999) Console.WriteLine("Вы ввели не трехзначное число");
else
{
    int ost = num % 100;
    ost = ost / 10;
    Console.WriteLine($"Вторая цифра числа: {ost}");
    Console.WriteLine();
}