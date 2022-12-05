// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

bool ElementExists(int[,] martix, int martixRows, int martixColumns)
{
    return martixRows < martix.GetLength(0) && martixColumns < martix.GetLength(1);
}

int ShowElement(int[,] matrix, int rowPosition, int columnPosition)
{
    return matrix[rowPosition, columnPosition];
}

int[,] newMatrix = CreateMatrixRndInt(5, 6, 0, 10);

Console.WriteLine("Введите координаты элемента:");
Console.Write("Индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Индекс столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

PrintMatrix(newMatrix);
Console.WriteLine();

if (ElementExists(newMatrix, row, column))
{
    Console.WriteLine($"Элемент на позиции ({row} , {column}) --> {ShowElement(newMatrix, row, column)}");
}
else Console.WriteLine($"Элемента на позиции ({row} , {column}) в массиве нет");