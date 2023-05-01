// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void FindElement(int[,] array, int rows, int col)
{
    if (rows > 10 | col > 10)
        {
            Console.WriteLine("Такого элемента в массиве нет");
        }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == rows & j == col)
            {
                Console.WriteLine($"Элемент с заданной позицией: {array[i, j]}");
            }
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i , j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrixMAndN(int rows, int col, int start, int end)
{
    int[,] array = new int[rows, col];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(start, end+1);
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int row = EnterData ("Введите номер строки массива row:  ");
int column = EnterData ("Введите номер столбца массива column:  ");
int[,] matrix = GetMatrixMAndN(10, 10, -10, 50);
Console.WriteLine($" Заданная позиция для элемента масива: [{row}, {column}] ");
PrintMatrix(matrix);
FindElement(matrix, row, column);
