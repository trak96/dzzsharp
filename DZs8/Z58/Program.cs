// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] ProizvedenieMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] PrMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    {
        for (int i = 0; i < PrMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < PrMatrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                PrMatrix[i, j] = sum;
            }
        }
    }
    return PrMatrix;
}

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



int[,] matrix1 = FillMatrix(4, 4, 0, 10);
int[,] matrix2 = FillMatrix(4, 4, 0, 10);
PrintMatrix(matrix1);
System.Console.WriteLine();
PrintMatrix(matrix2);
System.Console.WriteLine();
System.Console.WriteLine("Результат произведения матриц: ");
PrintMatrix(ProizvedenieMatrix(matrix1, matrix2));