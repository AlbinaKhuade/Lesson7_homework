// Задача 50. Напишите программу, которая
// на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите позиции элемента в массиве через пробел: ");
int[]array = Console.ReadLine().Split( ).Select(int.Parse).ToArray();

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

bool CheckElementInMatrix(int[] arr, int[,] matrix)
{
    return (arr[0] <= matrix.GetLength(0) && arr[1] <= matrix.GetLength(1));
}

int GetElementInMatrix(int[] arr, int[,] matrix)
{
    int i = arr[0]-1;
    int j = arr[1]-1;
    int num = matrix[i, j];
    return num;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 100);
PrintMatrix(array2D);

if (array[0] > 0 && array[1] > 0)
{
    bool checkElementInMatrix = CheckElementInMatrix(array, array2D);
    if (checkElementInMatrix) 
    {
        int element = GetElementInMatrix(array, array2D);
        Console.WriteLine($"{array[0]}, {array[1]} -> {element}");
    }
    else Console.WriteLine($"{array[0]}, {array[1]} -> Такого элемента в массиве нет");
}
else Console.WriteLine($"Введите корректные целые числа!");