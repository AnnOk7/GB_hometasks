﻿// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

double FindX(double a1, double c1, double a2, double c2)
{
    double x;
    x = Math.Round((c2 - c1) / (a1 - a2), 2);
    return x;
}

double FindY(double a1, double c1, double a2, double c2, double x)
{
    double y;
    y = Math.Round((a1 * x + c1), 2);
    y = Math.Round((a2 * x + c2), 2);
    return y;
}

Console.WriteLine("Введите число k1");
double k1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число k2");
double k2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b1");
double b1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b2");
double b2 = double.Parse(Console.ReadLine()!);

if (k2 != k1)
{
    double X = FindX(k1, b1, k2, b2);
    double Y = FindY(k1, b1, k2, b2, X);
    Console.WriteLine($"Прямые имеют точку пересечения с координатами ({X},{Y})");
}
else if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые имеют множество общих точек, т.е. накладываются др. на др.");
}

else if (k1 == k2 && b1 != b2)
{
    Console.WriteLine("Прямые не имеют множество общих точек, т.е. параллельны");
}