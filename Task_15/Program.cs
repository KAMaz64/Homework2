/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Clear();
Console.WriteLine("Введите порядковый номер дня недели (от 1 до 7)");
int N = int.Parse(Console.ReadLine());

if (N<1 || N>7)
{
    Console.WriteLine("Ошибка ввода данных");
}
else
{
    if (N==6 || N==7)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}