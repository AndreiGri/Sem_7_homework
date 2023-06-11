/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

using System;
using static System.Console;

Clear();                                                                 // Очищаем терминал

Write("Введите кол-во строк в массиве: ");                               // запрашиваем кол-во строк и столбцов
int row = int.Parse(ReadLine()!);
Write("Введите кол-во столбцов в массиве: ");
int col = int.Parse(ReadLine()!);
ArithMeanColumns(ArrIntMeth(row, col));                                 // Объявляем метод для выполнения

int[,] ArrIntMeth(int m, int n)                                         // Создаём метод для записи случайных чисел в массив
{
    WriteLine("Дан массив: ");
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Write($"{array[i, j]}  ");
        }
        WriteLine();
    }
    return array;                                                      // Возвращаем массив
}

void ArithMeanColumns(int[,] ar)                                       // Создаём метод для вычисления среднеарифметического в столбцах массива
{
    WriteLine("Среднеарифметическое значений в столбцах массива: ");
    for (int j = 0; j < ar.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < ar.GetLength(0); i++)
        {
            sum += ar[i, j];
        }
        Write($"{sum / ar.GetLength(0)}  ");
    }
}
