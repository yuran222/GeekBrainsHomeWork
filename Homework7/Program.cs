// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] DoubleArray(int m, int n)
// {
//     double[,] array = new double[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         array [i,j] = Math.Round(new Random().Next(-100,100+1)+new Random().NextDouble(), 2);
//     }
//     return array;
// }

// void ShowArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"[{array[i,j]}] ");  
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите число строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowArray(DoubleArray(m,n));





// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int[,] IntArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//             array[i, j] = new Random().Next(-100, 100 + 1);
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"[{array[i, j]}] ");
//         }
//         Console.WriteLine();
//     }
// }

// void search(int[,] array, int x, int y)
// {
//     int position = 0;
//     if (x > array.GetLength(0) || y > array.GetLength(1))
//     {
//         Console.WriteLine("элемента с данными координатами нет");
//     }
//     else
//     {
//         position = array[x, y];
//         Console.WriteLine($"элемента с координатами ({x},{y}) равен {position}");
//     }
// }

// Console.WriteLine("Введите число строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] NewArray = IntArray(m, n);
// ShowArray(NewArray);

// Console.WriteLine("Введите координату строки - i");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("ведите координату столбца - j");
// int y = Convert.ToInt32(Console.ReadLine());
// search(NewArray, x, y);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] IntArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(-100, 100 + 1);
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}] ");
        }
        Console.WriteLine();
    }
}

void avrg (int[,] array)
{
    double averege = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        averege = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            averege = averege + array [i,j];
        }
        Console.WriteLine($"Среднее значения столбца {j} равно {Math.Round(averege/(array.GetLength(0)),2)}");
    }
   
}

Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] NewArray = IntArray(m, n);
ShowArray(NewArray);
avrg(NewArray);