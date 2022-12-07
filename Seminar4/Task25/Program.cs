//  Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


int Power(int a, int b)
{
    int pow = 1;
    for (int i = 1; i <= b; i++)
        pow = pow * a;
    return pow;
}

Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат возведения числа A в натуральную степень B равен {Power(a, b)}");

Console.WriteLine();
