﻿// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

int [] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    
    }
    return result;
}

Console.Clear();

int[] array = GetArray(12,-9,9);
Console.WriteLine(string.Join(", ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach (int element in array)
{
    // // if (element > 0)
    // {
    // // {positiveSum += element;}
    // }
    positiveSum += element > 0 ? element : 0;
    negativeSum += element < 0 ? element : 0;
}
Console.WriteLine($"Сумма положительных чисел равна: {positiveSum}, а отрицательных: {negativeSum}");