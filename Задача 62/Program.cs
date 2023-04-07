/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

void PrintArray(int[,] matr)
{
    Console.WriteLine();
    Console.WriteLine($"На выходе получается вот такой массив:");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] / 10 <= 0)
            {
                Console.Write($"0{matr[i, j]} ");
            }
            else Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    int number = 1, i = 0, j = 0;
    while (number <= matr.GetLength(0) * matr.GetLength(1))
    {
        matr[i, j] = number;
        number++;
        if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matr.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

int rows, columns;
Console.Write($"Введите количество строк двумерного квадратного массива: ");
int.TryParse(Console.ReadLine()!, out rows);
Console.Write($"Введите количество столбцов двумерного квадратного массива: ");
int.TryParse(Console.ReadLine()!, out columns);
if (rows < 1 || columns < 1)
{
    Console.WriteLine();
    Console.WriteLine($"Невозможно создать массив с такими параметрами, пожалуйста перезапустите программу");
    Environment.Exit(0);
}
if (rows != columns)
{
    Console.WriteLine();
    Console.WriteLine($"Для создания квадратного массива пожалуйста введите количество строк и столбцов равное друг другу, пожалуйста перезапустите программу");
    Environment.Exit(0);
}
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);