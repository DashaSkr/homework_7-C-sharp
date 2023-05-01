// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void GetAverage(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца:  ");
    double sum = 0;
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            
        }
        average = average + sum/array.GetLength(1);
        
        Console.Write($"{average:F1}  ");
        sum = 0;
        average = 0;
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

int[,] matrix = GetMatrixMAndN(5, 5, 0, 10);
PrintMatrix(matrix);
GetAverage(matrix);
