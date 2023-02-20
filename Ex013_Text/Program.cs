// Дан текст. Нужно все пробелы заменить черточками.
// Маленькие буквы "к" и "с" на большие.


string text = "Я помню чудное мгновенье:"
            + "Передо мной явилась ты,"
            + "Как мимолетное виденье,"
            + "Как гений чистой красоты.";
// string s=  "qwerty"
//             012345
// s[3] -> r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
            if (text[i] == oldValue)
                result = result + $"{newValue}";
            else result = result + $"{text[i]}";
    }


    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);



Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);


