// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] Random3digitArray(int size)
// {
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }

// void show (int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             result++;
//         }
//         Console.Write(array[i] + " "); 
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Колличество четных чисел в массива равно {result}");
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] NewArray = Random3digitArray (size);
// show (NewArray);






// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] RandomArray(int size)
// {
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1,1000);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " "); 
//     }
//     Console.WriteLine();
// }

// void amount (int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i = i+2)
//     {
//         sum = sum + array[i];
//     }
//     Console.WriteLine($"сумма чисел на нечетных позициях равна {sum}");
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] NewArray = RandomArray (size);
// ShowArray (NewArray);
// amount (NewArray);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] RandomArray(int size)
// {
//     double[] array = new double [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Math.Round((new Random().Next(0,100) + new Random().NextDouble()), 2);
//     }
//     return array;
// }

// void ShowArray (double[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " "); 
//     }
//     Console.WriteLine();
// }

// void Min (double[] array)
// {
//     double Min = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (Min > array[i])
//         {
//             Min = array[i];
//         }
//     }
//     Console.WriteLine($"Минимальное число в массиве равно {Min}");
// }

// void Max (double[] array)
// {
//     double Max = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (Max < array[i])
//         {
//             Max = array[i];
//         }
//     }
//     Console.WriteLine($"Максимальное число в массиве равно {Max}");
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] NewArray = RandomArray (size);
// ShowArray (NewArray);
// Min(NewArray);
// Max(NewArray);