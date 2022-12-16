//задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
//Определить , является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - 
//площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, 
//равнобедренным, равносторонним.

void CheckNums(double a, double b, double c)
{
   if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Треугольник с такими сторонами существует");

        if (a == b && b == c)
        {
         Console.WriteLine("Треугольник является равносторонним");
         Console.WriteLine($"Его площадь равна {Math.Round(a * a * Math.Sqrt(3) / 4)}, периметр равен {3 * a}, углы равны 60 гр");            
        }
        else
        {
        double p = (a + b + c) / 2;
        double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        double alfa = Math.Round(Math.Acos((a * a + b * b - c * c) / (2 * a * b )) * 180 / Math.PI);
        double beta = Math.Round(Math.Acos((b * b + c * c - a * a) / (2 * b * c )) * 180 / Math.PI);
        double gamma = Math.Round(Math.Acos((a * a + c * c - b * b) / (2 * a * c )) * 180 / Math.PI);
        Console.Write($"Его площадь равна {Math.Round(square)}, ");
        Console.Write($"периметр равен {2 * p}, ");
        Console.Write($"углы равны {alfa} гр, {beta} гр, {gamma} гр ");          
        Console.WriteLine();       
        }

        if (a == b || b == c || a == c) Console.WriteLine("Также этот треугольник является равнобедренным");
        if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b) Console.WriteLine("Также этот треугольник является прямоугольным");
    }
    else Console.WriteLine("Такого треугольника не существует");
}

try
{
    Console.WriteLine("Введите значение 1 стороны треугольника: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение 2 стороны треугольника: ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение 3 стороны треугольника: ");
    double c = Convert.ToDouble(Console.ReadLine());
    CheckNums(a, b, c);
    Console.WriteLine();
}

catch
{
    Console.WriteLine("Ошибка ввода! Введите корректные числовые значения");
}


