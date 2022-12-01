//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел 
//от 1 до N.    5 -> 1, 8, 27, 64, 125

Console.WriteLine("Напишите целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 0) Console.WriteLine("Вы ввели отрицательное число или 0");
else
{
Console.WriteLine($"Кубы чисел от 1 до {n} равны: ");    
for (int i = 1; i <= n; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}
}
Console.WriteLine();
