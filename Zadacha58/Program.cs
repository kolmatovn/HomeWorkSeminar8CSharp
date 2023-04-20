// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


using System;
using static System.Console;

Write("Введите количество строк первого массива: ");
int rows1 = int.Parse(ReadLine());
Write("Введите количество столбцов первого массива и строк второго массива: ");
int columns1 = int.Parse(ReadLine());

Write("Введите количество столбцов второго массива: ");
int columns2 = int.Parse(ReadLine());

int[,] array1 = GetArray(rows1, columns1, 0, 10);
int[,] array2 = GetArray(columns1, columns2, 0, 10);
int[,] resultArray = new int[rows1, columns2];

PrintArray(array1);
WriteLine();
PrintArray(array2);
WriteLine();
MultiplyArrays(array1, array2, resultArray);
WriteLine($"Произведение первого и второго массива: ");
PrintArray(resultArray);



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void MultiplyArrays(int[,] array1, int[,] array2, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i,k] * array2[k,j];
            }
            resultArray[i,j] = sum;
        }
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}