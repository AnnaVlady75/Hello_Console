//Собрать строку с числами от a до b, a>=b
// от большего к меньшему

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i >= b; i--) // декремент
    {
        result += $"{i}";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b)
        return $"{a}" + NumbersRec(a + 1, b) + $"{a}";
    else return string.Empty;     // условие окончание
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));
