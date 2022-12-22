// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число ");
// int x = Convert.ToInt32(Console.ReadLine());
// x = x % 100;
// x = x / 10;
// Console.WriteLine(x);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// int lenght (int a)
// {
//     int Numlenght = 0;
//     while (a > 0)
//     {
//          a = a / 10;
//          Numlenght = Numlenght + 1;  
//     }
//     return (Numlenght);
// }

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int dlina = lenght(num);
// int stepen = Convert.ToInt32(Math.Pow(10, (dlina-3)));
// int ThirdNumber = ((num / stepen) % 10);
// Console.WriteLine($"Третья цифра числа {num} -> {ThirdNumber}");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковый день недели");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7)
    Console.WriteLine("Выходной. По пиву?");
else
    Console.WriteLine("Опять работа? Готов вкалывать.");
