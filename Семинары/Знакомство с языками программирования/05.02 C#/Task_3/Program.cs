// Определить количество цифр в числе

Console.Clear();

Console.WriteLine("Введите любое число ");
int Num = int.Parse(Console.ReadLine()!);
int res = 0;
int numCopy = Num;


while (Num > 0)
{
    Num = Num / 10; 
    res++;
}
Console.WriteLine($"Количество цифр в числе {numCopy}: {res}");