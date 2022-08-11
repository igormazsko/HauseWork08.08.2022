//Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
using static System.Console;
Clear();
WriteLine("введите число");
int a = int.Parse(ReadLine());
if (a <= 99)
{
    WriteLine("Третьей цифры нет");
}
else
{
    while ( a > 999 )
        {
            a = a / 10;
        }
    int b = a % 10;
    Write("Третья цифра числа - ");
    WriteLine(b);
}