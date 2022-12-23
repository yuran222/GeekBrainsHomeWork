// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


int lenght (int a)
{
    int Numlenght = 0;
    while (a > 0)
    {
         a = a / 10;
         Numlenght++;  
    }
    return (Numlenght);
}

bool polindrom (int number, int NumberLenght)
{
    for (int i = 1; i <= ((NumberLenght - 1)/2+1); i++)
    { 
        if (Math.Round((number % Math.Pow(10, i) / Math.Pow(10, i - 1)), 0) ==  Math.Round((number / Math.Pow(10, (NumberLenght - i)) % 10), 0)) 
        // Данное тяжелое по синтаксису условие проверяет все возможные числа, с четным и нечетным кол-вом символов. 
        // Размер вводимого можно расширить типом double.
        return true;
    }
    Console.WriteLine();
    return false;
}


Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int dlina = lenght(num);

if (polindrom(num, dlina))
    {
    Console.WriteLine("Данное число полиндром");
    }
else
    {
    Console.WriteLine("Данное число не полиндром");
    }



// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// void Distanse (double x1,double y1, double z1, double x2, double y2, double z2 )
// {
//      double result =Math.Round(Math.Sqrt(Math.Pow (x2-x1,2) + Math.Pow (y2-y1,2) + Math.Pow (z2-z1,2)),3);
//      Console.WriteLine("Расстояние между точками равно " + result);
// }
// Console.WriteLine("Ввеите координату 1 точки по оси X");
// double Ax = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Ввеите координату 1 точки по оси Y");
// double Ay = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Ввеите координату 1 точки по оси Z");
// double Az = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Ввеите координату 2 точки по оси X");
// double Bx = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Ввеите координату 2 точки по оси Y");
// double By = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Ввеите координату 2 точки по оси Z");
// double Bz = Convert.ToDouble(Console.ReadLine());
// Distanse(Ax,Ay,Az,Bx,By,Bz);

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void cube (int number)
// {
//     for (int i = 1; i <= number; i++)
//     {
//         Console.WriteLine($"Куб числа {i} равен {i*i*i}");
//     }
// }

// Console.WriteLine("Ввеите число до которого хотите построить таблицу кубов");
// int N = Convert.ToInt32(Console.ReadLine());

// cube (N);
