// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    // Random rand = new Random();
    var rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return tempMatrix;
}


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void PrintMatrix(int[,] matrixFotPrint)
{
    for (int i = 0; i < matrixFotPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFotPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixFotPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void ChangeElemets(int[,] matrix, int m, int n)
{
    if (m < 0 | m > matrix.GetLength(0)-1 | n < 0 | n > matrix.GetLength(1)-1)
    {
        Console.WriteLine("Элемент не существует  ");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", matrix[m, n]);
    }
}
//     }
// }


int m = ReadInt("Введите строку элемента: ");
int n = ReadInt("Введите столбец элемента: ");
int[,] matrix = FillMatrix(3, 4, 0, 50);
PrintMatrix(matrix);
System.Console.WriteLine("");
ChangeElemets(matrix,m,n);
