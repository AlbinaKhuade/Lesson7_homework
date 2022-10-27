// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns,  int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random(); 

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
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5}, ");
            else Console.Write($"{matrix[i,j], 5} ");    
        }
        Console.WriteLine("|");
    }
}

double[] AverageInColumns(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        double avg = (double)sum / matrix.GetLength(0);
        arr[j] = Math.Round(avg, 2);
        sum = 0;
    }
    return arr;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}.");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 100);
PrintMatrix(array2D);

double[] averageInColumns = AverageInColumns(array2D);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(averageInColumns);