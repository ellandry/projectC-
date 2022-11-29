//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным
Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7)
Console.WriteLine("Выход из диапазона. Введите корректный номер дня недели");
else
{
    if (day == 6 || day == 7) Console.WriteLine("Это выходной день");
    else
    {
        Console.WriteLine("Это рабочий день");
    }   
}
Console.WriteLine();
