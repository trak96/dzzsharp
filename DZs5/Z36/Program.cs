// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



void FillArray(int[] array)
{
    Random rand = new Random();
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = rand.Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    {
        System.Console.WriteLine("[" + string.Join(", ", array) + "]");
    }
}

int sumNegative(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}


int[] array = new int[6];
FillArray(array);
PrintArray(array);
System.Console.WriteLine(sumNegative(array));

