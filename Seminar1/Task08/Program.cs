//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < N-1; i = i + 2) Console.Write($"{i+2} ");//чтобы не выводить 0
