// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Clear();

string[] The_days_of_the_week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };


Console.WriteLine("Введите цифру, обозначающую день недели:");
int Num = int.Parse(Console.ReadLine()!);

int Day = Num - 1;

if (Day < The_days_of_the_week.Length)
{
    if (Num <= 5)
    {
        Console.WriteLine($"Это же {The_days_of_the_week[Day]} - рабочий день");
    }
    else
    {
        Console.WriteLine("Это выходной день");
    }
}
else 
{
   Console.WriteLine("Такого дня недели не существует"); 
}
