/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

using System;
using static System.Console;
Clear();                                                                 // Очищаем терминал

void ArrMeth(int m, int n)                                               // Создаём метод принимающий два числа 
{
    double[,] array = new double[m, n];                                  // Объявляем массив
    for (int i = 0; i < array.GetLength(0); i++)                         // Цикл строк
    {
        for (int j = 0; j < array.GetLength(1); j++)                     // Цикл столбцов
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 10, 2); // Записываем в ячейки строк переменную double округлённую до двух чисел после запятой
            Write($"{array[i, j]} ");                                    // выводим значение ячейки в терминал
        }
        WriteLine();                                                     // Переносимстроку
    }
}

Write("Введите кол-во строк в массиве: ");                               // запрашиваем кол-во строк и столбцов
int row = int.Parse(ReadLine()!);
Write("Введите кол-во столбцов в массиве: ");
int col = int.Parse(ReadLine()!);

WriteLine("Масив случайных существенных чисел:");                        // Текстовое сообщение, что происходит
ArrMeth(row, col);                                                       // вызываем метод ArrMeth()
