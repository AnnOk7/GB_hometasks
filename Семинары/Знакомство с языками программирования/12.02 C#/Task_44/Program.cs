﻿// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Clear();
int [] Fib(int N)
{
    int[] array = new int[N];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < N; i++)
    {
        array[i] = array[i-1] +array[i-2];
    }
    return array;
}
int N = int.Parse(Console.ReadLine()!);
int[] arr = Fib(N);
Console.WriteLine(string.Join(", ", arr));