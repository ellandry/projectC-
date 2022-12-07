// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//9012 -> 12
int SumDigit(double num)
{
    int count = 0;
    if (num < 0) num = - num;

    while (num % 10 != 0)
    {
     num = num * 10;   
    }
    
    num = num / 10;
    int num1 = Convert.ToInt32(num);
    
    while (num1 != 0)
    {
    num1 = num1 / 10;
    count++;  
    }
    return count;
}

Console.WriteLine("Введите целое или дробное число:");
double num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {num} равно {SumDigit(num)}");
Console.WriteLine();
