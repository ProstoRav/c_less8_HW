/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"Введите элемент массива в строке {i + 1}, столбце {j + 1}: ");
            bool success = int.TryParse(Console.ReadLine()!, out matr[i, j]);
            if (success)
            {

            }
            else
            {
                Console.WriteLine($"Программа принимает только целые числа в качестве элементов массива, пожалуйста перезапустите программу");
                Environment.Exit(0);
            }
        }
    }
    Console.WriteLine();
}

void ProductArray(int[,] matr1, int[,] matr2, int[,] resultmatr)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int n = 0; n < matr1.GetLength(1); n++)
            {
                resultmatr[i, j] += matr1[i, n] * matr2[n, j];
            }
        }
    }
    Console.WriteLine($"Результирующая матрица будет: ");
    for (int i = 0; i < resultmatr.GetLength(0); i++)
    {
        for (int j = 0; j < resultmatr.GetLength(1); j++)
        {
            Console.Write($"{resultmatr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CheckArray(int rows, int columns)
{
    if (rows < 1 || columns < 1)
    {
        Console.WriteLine($"Невозможно создать массив с такими параметрами, пожалуйста перезапустите программу");
        Environment.Exit(0);
    }
}

int rows1, columns1, rows2, columns2;

Console.Write($"Введите количество строк первого двумерного массива: ");
int.TryParse(Console.ReadLine()!, out rows1);
Console.Write($"Введите количество столбцов первого двумерного массива: ");
int.TryParse(Console.ReadLine()!, out columns1);
CheckArray(rows1, columns1);
int[,] matrix1 = new int[rows1, columns1];
FillArray(matrix1);

Console.Write($"Введите количество строк второго двумерного массива: ");
int.TryParse(Console.ReadLine()!, out rows2);
Console.Write($"Введите количество столбцов второго двумерного массива: ");
int.TryParse(Console.ReadLine()!, out columns2);
CheckArray(rows2, columns2);
int[,] matrix2 = new int[rows2, columns2];
FillArray(matrix2);

if (columns1 != rows2)
{
    Console.WriteLine($"Для произведения матриц необходимо чтобы столбцы первой равнялись количеству строк второй, пожалуйста перезапустите программу");
    Environment.Exit(0);
}

int[,] resultmatrix = new int[rows1, columns2];

Console.WriteLine($"Первый массив: ");
PrintArray(matrix1);
Console.WriteLine($"Второй массив: ");
PrintArray(matrix2);

ProductArray(matrix1, matrix2, resultmatrix);