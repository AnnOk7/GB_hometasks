// Найти сумму чисел от 1 до A

Console.Clear();

Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine()!);
int Sum = 0;

for (int count = 1; count <= A; count++)
{
    Sum += count;
}
Console.WriteLine(Sum);
