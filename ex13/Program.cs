// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

/*
int i;
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    int x = num;
    for (i = 0; x > 0; i++)
    {
        x = x / 10;        
    }
    Console.WriteLine($"{x} значное число");
    Console.WriteLine($"Третья цифра числа: {num / (10 ^ i) * 1000 % 10}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
*/


int znak;
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 && num > -100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int temp = num;
    for (znak = 0; temp != 0; znak++)
    {
        temp = temp / 10;
    }
    Console.WriteLine($"{znak} значное число");
    temp = Convert.ToInt32(Math.Pow(10, znak - 3));
        num = num / temp % 10;
    if (num < 0) num = -num;
    Console.WriteLine($"Третья цифра числа: {num}");
}