//1 тип Метода, который ничего не возвращает и ничего не принимает
void Method1()
{
    Console.WriteLine("Пишем текст ");
}
//Вызов метода:
//Method1();

//2 тип Метода, который ничего не возвращает, но принимает аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(" Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
//Method21(msg:" Текст сообщения", count: 3);


//3 тип Метода, который возвращает, но ничего не принимает 
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//4 тип Метода, который что-то принимает и что-то возвращает

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "q");
Console.WriteLine(res);