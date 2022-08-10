// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру
using static System.Console;
Clear();
WriteLine("Введите трёхзначное число ");
int a = Convert.ToInt32(ReadLine());
if (a>99 && a<1000)
{
    int b = a / 10;
    int c = b % 10;
    Write("Вторая цифра числа - ");
    WriteLine(c);
}
else
{
    WriteLine("введено не трёхзначное число");
}