// // Группы методов

// // Вид 1 (ничего не принимает, ничего не возвращает)
// void Method1()
// {
//     Console.WriteLine("Автор ... ");
// }
// // Method1();

// // Вид 2 (Что-то принимает, ничего не возвращает)
// void Method2(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method2(msg: "Текст сообщения", count: 4);
// Method2(count: 4, msg: "новый текст");


// // Вид 3 (Ничего не принимают, что-то возвращают)

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3(); 
// Console.WriteLine(year);

// Вид 4 (Что-то принимают, что-то возвращают)

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "text ");
Console.WriteLine(res);

