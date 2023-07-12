// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29z


int ReadInt(string text) //double, int[], string, void
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
} 



int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (M > 0 & N ==0)
    {
        return Akkerman(M-1, 1);
    }
    return Akkerman(M-1,Akkerman(M,N-1));
}


int M = ReadInt("Введите число М: ");
int N = ReadInt("Введите число N: ");
System.Console.WriteLine(Akkerman(M,N));