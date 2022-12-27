


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("Введите число А");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень B");
// int B = Convert.ToInt32(Console.ReadLine());

// int result = A;

// for (int i = 1; i < B; i++)
// {
//     result = result * A;
// }

// Console.WriteLine($"Число {A} в степени {B} равно {result}");







// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int summa (int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result = result + number % 10;
//         number = number / 10;
//     }
//     return result;
// }

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = summa (num);
// Console.WriteLine($"Сумма цифр числа {num}  равна {result}");








// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] RandomArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,1000);
    }
    return array;
}

void show (int[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
}

int size = 8;
int[] NewArray = RandomArray (size);
show (NewArray);