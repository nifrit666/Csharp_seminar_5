﻿/*
Задайте двумерный массив из целых чисел. 
Сформируйте новый одномерный массив, состоящий из средних арифметических значений по строкам двумерного массива.

Пример:
2 3 4 3 
4 3 4 1    =>  [3 3 5]
2 9 5 4 
*/


int[,] GetMatrixRndInd(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // (0) строка 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // (1) столбец
        {
            matrix[i, j] = rnd.Next(min, max); //последнее число max не входит
        }
    }                  // в данном цикле идёт проход по строкам, если хотим, чтобы проходил по стобцам, то нужно поменять местами наши циклы
                       // т.е. сначала будет for с j идти, а потом с i
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}"); // 4 это длина строки в которую будем вмещать наш результат (для каждого элемента)
        }
        Console.WriteLine();
    }
}

double[] AverageRows(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i, j];
        }
        array[i] = (double)summ / matrix.GetLength(1); // явное приведение типа double, чтобы было не целочисленное деление (ПРИНУДИТЕЛЬНО)
    }

    return array;
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:F2} "); // F2 округление до 2-х знаков 
    }
}



int[,] array2D = GetMatrixRndInd(3, 4, 1, 10); // int rows, int columns, int min, int max
PrintMatrix(array2D);
Console.WriteLine();
double[] array = AverageRows(array2D);
Console.WriteLine();
PrintArray(array);