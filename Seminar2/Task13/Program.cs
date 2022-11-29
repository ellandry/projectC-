// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.Через строку решать нельзя
Console.WriteLine("Введите целое число:");
int a = Convert.ToInt32(Console.ReadLine());
int b;
int rev = 0;
if (a < 0) a = -a;

if (a < 100) Console.WriteLine("Третья цифра во введенном числе отсутствует");
else
{
    while (a != 0) //делаем переворот числа
    {
    b = a % 10;        
    rev = (rev * 10) + b;   
    a = a / 10;             
    }
int ost = rev % 1000;
ost = ost / 100;

Console.WriteLine($"Третья цифра во введенном числе: {ost} ");
}
Console.WriteLine();
