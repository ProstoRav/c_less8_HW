/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void FindMinRowSum(int[,] matr)
{
    int minsum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        minsum += matr[0, j];
    }
    int[] result = new int[matr.GetLength(0) + 1];
    int[] currentsum = new int[matr.GetLength(0) + 1];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            currentsum[i] += matr[i, j];
        }
        if (currentsum[i] < minsum)
        {
            minsum = currentsum[i];
        }
        result[i] = i + 1;
    }
    Console.Write($"Номер строк с наименьшей суммой элементов: ");
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (currentsum[i] == minsum)
        {
            Console.Write($"{result[i]} ");
        }

    }
    Console.Write($"строка");
}

int rows, columns;
Console.Write($"Введите количество строк двумерного массива: ");
int.TryParse(Console.ReadLine()!, out rows);
Console.Write($"Введите количество столбцов двумерного массива: ");
int.TryParse(Console.ReadLine()!, out columns);
if (rows < 1 || columns < 1)
{
    Console.WriteLine($"Невозможно создать массив с такими параметрами, пожалуйста перезапустите программу");
    Environment.Exit(0);
}
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
FindMinRowSum(matrix);