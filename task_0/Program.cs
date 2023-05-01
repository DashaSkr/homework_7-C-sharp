// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i , j]:F1}  ");
        }
        Console.WriteLine();
    }
}

double[,] GetMatrixMAndN(int rows, int col, double minValue, double maxValue)
{
    double[,] array = new double[rows, col];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue ;
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int m = EnterData("Введите число m: ");
int n = EnterData("Введите число n: ");
double[,] matrix = GetMatrixMAndN(m, n, -10, 10);
Console.WriteLine($"m = {m}, n = {n}. ");
PrintMatrix(matrix);



