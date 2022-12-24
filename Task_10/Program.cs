﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();
Console.WriteLine("Введите произвольное трехзначное число ");
int N = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(N)<100 || Math.Abs(N)>999)
{
    Console.WriteLine("Ошибка ввода данных. Число должно быть трехзначным");
}
else
{
    Console.WriteLine($"{Math.Abs(N) / 10 % 10}");
}