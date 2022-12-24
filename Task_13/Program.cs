/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.Clear();
Console.WriteLine("Введите произвольное число");
int N = Convert.ToInt32(Console.ReadLine());
int n = Math.Abs(N);

if (n<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (n>1000)
    {
        n /= 10;
    }
    Console.WriteLine(n%10);
}