// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillArray(int[] array)
{
    Random rand = new Random();
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = rand.Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    {
        System.Console.WriteLine("[" + string.Join(", ", array) + "]");
    }
}

int sumPos(int[] array)
{
    int sum = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index]%2 == 0)
        {
            sum++;
        }
    }
    return sum;
}


int[] array = new int[12];
FillArray(array);
PrintArray(array);
System.Console.WriteLine("Количество четных чисел: " + sumPos(array));

