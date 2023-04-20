// В тексте нужно все пробелы заменить черточками, 
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

string text = "Гой ты, Русь, моя родная…"
+ "Гой ты, Русь, моя родная,"
+ "Хаты — в ризах образа…"
+ "Не видать конца и края —"
+ "Только синь сосет глаза.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);

