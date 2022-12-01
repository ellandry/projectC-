//Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
//является ли оно палиндромом. Через строку решать нельзя
Console.WriteLine("Введите целое число любой разрядности:");
int a = Convert.ToInt32(Console.ReadLine());
int b;
int rev = 0;
int c = a;
if (a < 10 && a > -10) Console.WriteLine("Вы ввели однозначное число");
else
{
    while (a != 0) //делаем переворот числа
    {
    b = a % 10;        
    rev = (rev * 10) + b;   
    a = a / 10;             
    }

    if (rev == c) Console.WriteLine($"Введенное число {c} является палиндромом");
    else
    {
        Console.WriteLine($"Введенное число {c} не является палиндромом");
    }
}
Console.WriteLine();
