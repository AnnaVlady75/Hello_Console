Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "Кирилл")
{
    Console.WriteLine("Ура, это ведь Кирилл!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
