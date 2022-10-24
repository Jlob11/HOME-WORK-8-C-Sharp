/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

/* Console.WriteLine("Количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов ");
int colums = int.Parse(Console.ReadLine());

int[,] array = Getarray(rows, colums, 0, 10);
Printarray(array);
Console.WriteLine();
// ArrangeToLow(array);
// Printarray(array);

void ArrangeToLow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int b = 0; b < array.GetLength(1) - 1; b++)
            {
                if (array[i, b] < array[i, b + 1])
                {
                    int time = array[i, b + 1];
                    array[i, b + 1] = array[i, b];
                    array[i, b] = time;
                }
            }
        }
    }
}

 */
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:


Console.WriteLine("Количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов ");
int colums = int.Parse(Console.ReadLine());

int[,] array = Getarray(rows, colums, 0, 10);
Printarray(array);
Console.WriteLine();
RowMinSum(array);
Printarray(array);


void RowMinSum(int[,] array)
{
    int mRow = 0;
    int mSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        mRow =mRow + array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow = sumRow + array[i, j];
        if (sumRow < mRow)
        {
            mRow = sumRow;
            mSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{mSumRow + 1} строка");
    Console.WriteLine();
}
































int[,] Getarray(int m, int n, int minvalue, int maxvalue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minvalue, maxvalue + 1);
        }
    }
    return result;
}

void Printarray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}