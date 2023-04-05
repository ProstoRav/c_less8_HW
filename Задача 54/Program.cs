/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

void SortRowHighLow(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int n = 0; n < matr.GetLength(1) - 1; n++)
            {
                if (matr[i, n] < matr[i, n + 1])
                {
                    int temp = matr[i, n + 1];
                    matr[i, n + 1] = matr[i, n];
                    matr[i, n] = temp;
                }
            }
        }
    }
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
Console.WriteLine($"Задан массив:");
PrintArray(matrix);
SortRowHighLow(matrix);
Console.WriteLine($"В итоге получается вот такой массив:");
PrintArray(matrix);