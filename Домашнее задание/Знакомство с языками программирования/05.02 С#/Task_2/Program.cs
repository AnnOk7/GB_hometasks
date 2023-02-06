// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int factorial = 1;

for (int i = 1; i <= num; i++)
{
    factorial *= i;
    if (i == num)
    {
        Console.Write("{0}", i);
    }
    else
    {
        Console.Write("{0} * ", i);
    }
}
Console.Write(" = {0}", factorial);
