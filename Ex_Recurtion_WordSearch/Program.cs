//  Перебор слов. В некотором машинном оборудовании
// имеются 4 буквы А,И,С и В. Показать все слова,
// состоящие из Т букв, которые можно построить из них. Усли неизвестно 
// Т(сколько букв в словах) Разбиение на команды.

// char[] s = { 'а', 'и', 'с', 'в' };
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)  // однобуквенные слова
// {
//     for (int j = 0; j < count; j++)
//     {
//         Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");  // двубуквенные слова и т.д.

//     }
// }

int n=1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++}{new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв",new char[4]);

