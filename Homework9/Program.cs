// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int numbers (int N)
// {
//     if (N == 0)
//         return 0;
//     else
//         Console.Write(N + " ");
//         return numbers(N-1); 
// }

// Console.WriteLine("Введите число");
// int X = Convert.ToInt32(Console.ReadLine());
// numbers(X);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int PrintNum(int num1, int num2)
// {
//     if (num1 != num2)
//     {
//         int Sum = 0;
//         if (num1 > num2) // 3 > 0 // 3 + 2 + 1 = 6
//         {
//             Sum = num1 + PrintNum(num1 - 1, num2);
//         }
//         if (num2 > num1)
//         {
//             Sum = num2 + PrintNum(num1, num2 - 1);
//         }
//         return Sum;
//     }
//     else
//     {
//         return num1;
//     }
// }

// Console.WriteLine("Введите число M");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// int total = PrintNum(M, N);

// if (M > N)
//     Console.Write($"Cумма чисел от {N} до {M} равна {total}");
// else
//     Console.Write($"Cумма чисел от {M} до {N} равна {total}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackerman (int m, int n)
{
    int Result = 0;
    if (m == 0 )
        {
            Result = n + 1;
        }
    if (m > 0 && n == 0)
        {
            Result = Ackerman(m-1, 1);
        }
    if (m > 0 && n > 0)
        {
            Result = Ackerman(m-1,Ackerman(m,n-1));
        }
    return Result;
}

Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
int total = Ackerman(m, n);
Console.Write($"Результат вычисления функции Аккермана равен {total}");
