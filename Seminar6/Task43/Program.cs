//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Intersection(double k1, double b1, double k2, double b2)
{
    double x;
    double y;
    if (k1 == k2) Console.WriteLine("Введите корректные значения k1 и k2");
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"Координаты точки пересечения двух прямых ({x};{y})");
    }
}

Console.WriteLine("Введите число k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Intersection(k1, b1, k2, b2);
Console.WriteLine();
