// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// int[] SavedNumbers(int size)
// {
//     int[] array = new int[size];
//     Console.WriteLine($"Введите {size} чисел");
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Введеные вами числа:");
//     for (int i = 0; i < array.Length; i++)
//     {

//         Console.Write(array[i] + " ");
//     }
// }

// void CountPositive(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"Из которых больше нуля {count}");
// }

// Console.WriteLine("Сколько чисел вы хотите ввести?");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] number = SavedNumbers(m);
// ShowArray(number);
// CountPositive(number);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void intersection (double k1,double b1,double k2,double b2)
{
    double x = Math.Round((b2 - b1)/ (k1 - k2),2);
    double y = Math.Round(k2 * x + b2,2); 
    if (k1 == k2)
    {
        Console.WriteLine("Данные прямые параллельны, пересечения нет");
    }
    else
    {
        Console.WriteLine($"Координаты точки пересечения ({x},{y})");
    }
}

Console.WriteLine("Введите k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToInt32(Console.ReadLine());

intersection (k1, b1, k2, b2);