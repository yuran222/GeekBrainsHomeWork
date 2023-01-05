// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] CreateArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i,j] = new Random().Next(0,10);
//             }
//         }
//     return array;
// }

// void ShowArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array [i,j] + " ");
//             }
//             Console.WriteLine();
//         }

// }

// int[,] BubbleSortArray(int[,] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 for (int z = 0; z < array.GetLength(1) - 1; z++)
//                 {
//                     if (array [i,z] < array [i,z+1] )
//                     {
//                         temp = array [i,z];
//                         array [i,z] = array [i,z + 1];
//                         array [i,z + 1] = temp;
//                     }
//                 }
//             }
//         }
//     return array;
// }


// Console.WriteLine("Введите кол-во строк масива");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во стобцов масива");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array1 = CreateArray(m,n);
// Console.WriteLine("Базовый массив:");
// ShowArray(array1);
// int[,] SortedArray1 = BubbleSortArray(array1);
// Console.WriteLine("Отсортированый массив:");
// ShowArray(SortedArray1);






// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] CreateArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// void FindRow(int[,] array)
// {
//     int MinRow = 0;
//     int MinSum = 0;
//     int temp = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//         {
//          MinSum += array[0,j];
//         }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         temp = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             temp = temp + array[i, j];
//         }
//         if (temp < MinSum)
//         {
//             MinSum = temp;
//             MinRow = i;
//         }
//     }
//     Console.WriteLine($"Минимальная сумма {MinSum} находится в строке {MinRow}");
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите кол-во строк массива");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов массива");
// int n = Convert.ToInt32(Console.ReadLine());

// if (m == n)
// {
//     Console.WriteLine("Вы ввели квадратный массив, пожалуйста введите прямоугольный массив");
// }
// else
// {
//     int[,] array1 = CreateArray(m, n);
//     FindRow(array1);
//     ShowArray(array1);
// }




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] CreateArray()
// {
//     int[,] array = new int[2, 2];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// int[,] multiplication(int[,] array1, int[,] array2)
// {
//     int[,] array3 = new int[2, 2];
//     for (int i = 0; i < array3.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3.GetLength(0); k++)
//             {
//             array3[i, j] += array1[i, k] * array2[k, j];
//             Console.WriteLine($"умножается {array1[i, k]} на  {array2[k, j]}");
//             }
//         }
//     }
//     return array3;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] arrayA = CreateArray();
// int[,] arrayB = CreateArray();
// Console.WriteLine("Первая матрица");
// ShowArray(arrayA);
// Console.WriteLine("Вторая матрица");
// ShowArray(arrayB);
// Console.WriteLine("Произведение матриц");
// int[,] ArrayMulti = multiplication(arrayA, arrayB);
// ShowArray(ArrayMulti);






// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] CreateArray(int x, int y, int z)
// {
//     int[,,] array = new int[x, y, z];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = new Random().Next(0, 10);
//             }
//         }
//     }
//     return array;
// }

// void ShowArray(int[,,] array)
// {
//     for (int k = 0; k < array.GetLength(2); k++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             Console.WriteLine();
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j, k] + $"({i},{j},{k})");
//             }
//         }
//     }
// }

// Console.WriteLine("Введите кол-во строк массива");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов массива");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите глубину массива");
// int z = Convert.ToInt32(Console.ReadLine());
// int[,,] array3D = CreateArray(x, y, z);

// ShowArray(array3D);







// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateArray(int n)
{
    int[,] array = new int[n, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 0;
        }
    }
    return array;
}

int[,] FillArray(int[,] array)
{
    int nubmer = 01;
    int StartRawAndColumn = 0;
    while (StartRawAndColumn < (array.GetLength(0) + 1) / 2) 
    {
        for (int j = StartRawAndColumn; j < array.GetLength(1) - StartRawAndColumn; j++)
        {
            int i = StartRawAndColumn;
            if (array[i, j] == 0)
            {
                array[i, j] = nubmer;
                nubmer++;
            }
        }
        for (int i = StartRawAndColumn; i < array.GetLength(0); i++)
        {
            int j = array.GetLength(1) - 1 - StartRawAndColumn;
            if (array[i, j] == 0)
            {
                array[i, j] = nubmer;
                nubmer++;
            }
        }
        for (int j = array.GetLength(1) - 1 - StartRawAndColumn; j >= 0; j--)
        {
            int i = array.GetLength(0) - 1 - StartRawAndColumn;
            if (array[i, j] == 0)
            {
                array[i, j] = nubmer;
                nubmer++;
            }
        }
        for (int i = array.GetLength(0) - StartRawAndColumn - 1; i >= 0; i--)
        {
            int j = StartRawAndColumn;
            if (array[i, j] == 0)
            {
                array[i, j] = nubmer;
                nubmer++;
            }
        }
        StartRawAndColumn++;
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 == 0)
            {
                Console.Write("0"+array[i, j] + " ");
            }
            else
            { 
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите сторону массива n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateArray(n);
Console.WriteLine("Пустой массив");
ShowArray(array);
FillArray(array);
Console.WriteLine("Заполненый по спирали массив");
ShowArray(array);

//данная программа заполняет любой по размеру квадратный массив, хоть 4 на 4, хоть 12 на 12, хоть 99 на 99