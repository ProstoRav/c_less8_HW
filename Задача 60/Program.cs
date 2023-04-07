/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

void PrintArray(int[,,] matr)
{
    for (int n = 0; n < matr.GetLength(2); n++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j, n]}({i},{j},{n}) ");
            }
            Console.WriteLine();
        }
    }
}

void FillArray(int[,,] matr)
{
    var randomnumbers = Enumerable.Range(10, 90).ToList();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int n = 0; n < matr.GetLength(2); n++)
            {
                var uniqueindex = new Random().Next(0, randomnumbers.Count);
                var uniquenumber = randomnumbers[uniqueindex];
                randomnumbers.RemoveAt(uniqueindex);
                matr[i, j, n] = uniquenumber;
            }
        }
    }
}

int rows, columns, layers;
Console.Write($"Введите количество строк трёхмерного массива: ");
int.TryParse(Console.ReadLine()!, out rows);
Console.Write($"Введите количество столбцов трёхмерного массива: ");
int.TryParse(Console.ReadLine()!, out columns);
Console.Write($"Введите количество слоёв трёхмерного массива: ");
int.TryParse(Console.ReadLine()!, out layers);
if (rows < 1 || columns < 1 || layers < 1)
{
    Console.WriteLine($"Невозможно создать массив с такими параметрами, пожалуйста перезапустите программу");
    Environment.Exit(0);
}
int[,,] matrix = new int[rows, columns, layers];
FillArray(matrix);
PrintArray(matrix);