//Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число c: ");
int c = Convert.ToInt32(Console.ReadLine());
    if (a >= b && a > c)
        Console.WriteLine($"Максимальное из введенных чисел первое число:  {a}");
        else if (a >= b && a < c)
        {
            Console.WriteLine($"Максимальное из введенных чисел третье число:  {c}");
        }
            else if (a <= b && b > c)
            {
                Console.WriteLine($"Максимальное из введенных чисел второе число:  {b}");
            }
                else if (a <= b && b < c)
                {
                    Console.WriteLine($"Максимальное из введенных чисел третье число:  {c}");
                }
                    else
                    {
                         Console.WriteLine($"Вы ввели одинаковые числа");
                    }
