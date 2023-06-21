// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите число: ");
string str = Console.ReadLine()!;
int len = str.Length;

if (len == 5)
{
    if (str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine($"{str} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{str} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"{str} - не является пятизначным");
}