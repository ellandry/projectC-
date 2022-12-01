// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
// ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.
Console.Write("Введите размерность пространства: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1) Console.WriteLine("Введите целое положительное число");
else
{
double[] x = new double[n];
double[] y = new double[n];
double square = 0;

try
{
    for(int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите координаты точки А[{i+1}] ");
        x[i] = Convert.ToDouble(Console.ReadLine()); 
    }
    for(int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите координаты точки B[{i+1}] ");
        y[i] = Convert.ToDouble(Console.ReadLine());  
    }
    for (int i = 0; i < n; i++)
    {
        square = square + Math.Pow((x[i]-y[i]), 2);
    }
    double distance = Math.Round(Math.Sqrt(square), 2);
    Console.WriteLine($"Расстояние между введенными точками составляет: {distance}");
}
catch
{
    Console.WriteLine("Проверьте правильность ввода данных");
}
    Console.WriteLine();
}
