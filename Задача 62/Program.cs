/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

void PrintArray(int[,] matr)
{
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

int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);