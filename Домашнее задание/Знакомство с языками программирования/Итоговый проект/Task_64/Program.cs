﻿// // Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.Clear();
string Recursion(int N)
{
    if (N == 1) return N.ToString();
    else
    {
        return N.ToString()+", " + Recursion(N - 1);
    }
}
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Натуральные числа до введенного числа включительно в обратную сторону: {Recursion(N)}");