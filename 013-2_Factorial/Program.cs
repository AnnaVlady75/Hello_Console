// Найти факториал
// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n* Factorial(n - 1);
// }

// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// Фибоначчи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1)+f(n-2)

double Fibonacci(int n)
{
    if (n==1||n==2) return 1;
    else
    {
        return Fibonacci(n-1)+Fibonacci(n-2);
    }
}

for (int i = 1; i < 30; i++)
{
    Console.WriteLine($"f{i} = {Fibonacci(i)}");
}