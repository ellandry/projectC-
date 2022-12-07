// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//9012 -> 12
int SumDigit(int num)
{
    int b;
    int sum = 0;
    if (num < 0) num = - num;

    while (num != 0)
    {
    b = num % 10;        
    sum = sum + b;   
    num = num / 10;             
    }
    return sum;
}

Console.WriteLine("Введите целое число любой разрядности:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {num} равна {SumDigit(num)}");
Console.WriteLine();
