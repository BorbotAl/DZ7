// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMaxtixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(num, 1);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}; ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

bool MatrixPossible(int rows, int columns)
{
    return rows > 1 && columns > 0;
}

bool RangePossible(int min, int max)
{
    return max > min;
}


Console.WriteLine("Введите количество строк двумерного массива:");
int countRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива:");
int countColumns = Convert.ToInt32(Console.ReadLine());

if (MatrixPossible(countRows, countColumns))
{
    Console.WriteLine("Введите минимальное значение элемента двумерного массива:");
    int minElement = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите максимальное значение элемента двумерного массива:");
    int maxElement = Convert.ToInt32(Console.ReadLine());

    if (RangePossible(minElement, maxElement))
    {
        double[,] userMatrix = CreateMaxtixRndDouble(countRows, countColumns, minElement, maxElement);
        PrintMatrix(userMatrix);
    }
    else Console.WriteLine("Неверно задан диапазон допустимых значений");
}
else Console.WriteLine("Невозможно создать двумерный массив с такими параметрами");