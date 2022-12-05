// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],6}, ");
            else Console.Write($"{matrix[i, j],6} ");
        }
        Console.WriteLine("|");
    }
}

double ArithmetiсMeanColumn(double[,] matrix, int column)
{
    double arithmetiсMean = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        arithmetiсMean += matrix[i, column] / matrix.GetLength(0);
    }
    return arithmetiсMean;
}


double[,] newMatrix = CreateMatrixRndInt(4, 5, 0, 10);
PrintMatrix(newMatrix);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца");
for (int i = 0; i < newMatrix.GetLength(1); i++)
{
    double result = Math.Round(ArithmetiсMeanColumn(newMatrix, i), 2);
    Console.Write($"{result, 6}; ");
}