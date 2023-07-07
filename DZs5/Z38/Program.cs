// // Задача 38: Задайте массив вещественных чисел. Найдите  разницу между максимальным и минимальным элементов массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76




double Sum(double[] array)
{
    double sum = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            {
                max = array[i];
            }
        if (array[i] < min)
            {
                min = array[i];
            }
    }
    sum = max - min;
    return sum;
}

void FillArray(double[] array)
{
    Random rand = new Random();
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = Math.Round(rand.Next(1,20) + rand.NextDouble(),3);
    }
}

void PrintArray(double[] array)
{
    {
        System.Console.WriteLine("[" + string.Join("; ", array) + "]");
    }
}

double[] arr = new double[10];
FillArray(arr);
PrintArray(arr);
System.Console.WriteLine(Math.Round(Sum(arr),3));




