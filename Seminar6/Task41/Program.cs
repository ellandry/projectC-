//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
//ввёл пользователь. 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3
using System.Linq;
int[] FillArray(string textNumbers)
{
    if (textNumbers == "") return new int[] {0};
    else
    {    
    var data = textNumbers.Split(" ")
                    .Select(el => int.Parse(el))
                    .ToArray();
    return data;
    }
}

void PrintPozitivEl(int[] array)
{
    foreach (int el in array)
    { 
        if (el > 0) Console.Write($"{el} ");
        if (array.Length == 0 || array.Length == 1 && el == 0) Console.Write("Проверьте правильность ввода данных");
   }
    Console.WriteLine();
}

try
{
Console.Write("Введите через пробел любое количество целых чисел:  ");

string textNumbers = Console.ReadLine();

int[] array = FillArray(textNumbers);
Console.WriteLine();
Console.Write($"Положительные числа: ");
PrintPozitivEl(array);
Console.WriteLine();
}

catch
{
Console.WriteLine("Проверьте правильность ввода данных");
Console.WriteLine();
}