int[] numbers = { 3, -7, 15, -4, 23 };
int i = 0;
while (i < numbers.Length)
{
    if (numbers[i] > 0) Console.WriteLine($"{numbers[i]}, ");
    i++;
}