// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



int Counter(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int ReadInt(string text) //double, int[], string, void
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
} 

int number = ReadInt("Введите число: ");

System.Console.WriteLine(Counter(number));