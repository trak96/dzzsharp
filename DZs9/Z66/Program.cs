// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ReadInt(string text) //double, int[], string, void
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
} 

int Summator(int M, int N)
{
    if (N < 0)
    {
        return 0;
    }
    
    return N + Summator(M,N-1);
}

int M = ReadInt("Введите число М: ");
int N = ReadInt("Введите число N: ");
System.Console.WriteLine(Summator(M,N));