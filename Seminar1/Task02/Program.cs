Console.WriteLine("Введите первое целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число b: ");
int b = Convert.ToInt32(Console.ReadLine());
    if (a > b)
        Console.WriteLine($"Максимальное из введенных чисел первое число:  {a}");
        else if (a < b)
        {
            Console.WriteLine($"Максимальное из введенных чисел второе число:  {b}");
        }
            else
            {
                Console.WriteLine($"Вы ввели одинаковые числа");
            }
