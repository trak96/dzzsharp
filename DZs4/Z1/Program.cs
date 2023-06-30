// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Result(int a, int b)
{
    int result = (int)Math.Pow(a, b);
    return result;
}

int number1 = ReadInt("Введите 1е число: ");
int number2 = ReadInt("Введите 2е число: ");
System.Console.WriteLine(Result(number1, number2));