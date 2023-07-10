// Задача 60. Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillMatrix(int row, int col, int rog, int leftRange, int rightRange)
{
    int[,,] tempMatrix = new int[row,col,rog];
    // Random rand = new Random();
    var rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < tempMatrix.GetLength(2); k++)
            {
                tempMatrix[i, j, k] = rand.Next(leftRange, rightRange + 1);
            }
        }
    }

    return tempMatrix;
}


void PrintMatrix(int[,,] matrixFotPrint)
{
    for (int i = 0; i < matrixFotPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFotPrint.GetLength(1); j++)
        {
            System.Console.WriteLine();
            for (int k = 0; k < matrixFotPrint.GetLength(2); k++)
            {
                System.Console.Write($"{matrixFotPrint[i, j, k]} ({i},{j},{k})" + "\t");
            }
        }
        System.Console.WriteLine();
    }
}


int[,,] matrix = FillMatrix(2,2,2, 10, 100);
PrintMatrix(matrix);