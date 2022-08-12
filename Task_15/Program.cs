// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
using static System.Console;
Clear();
WriteLine("Введите цифру обозначающую день недели");
int n = int.Parse(ReadLine());
if (n>=1 && n<=5)
{
    WriteLine("рабочий");
}
else
{
    if (n==6 ^ n==7)
    {
        WriteLine("Ура! выходной");
    }
    else
    {
        Write("Дня № ");
        Write( n );
        WriteLine(" в неделе нет");

    }
}