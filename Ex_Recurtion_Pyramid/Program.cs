// Игра в пирамидки/  с 1 на 3, с 1 на 2, с 3 на 2, с 1 на 3, со 2 на 3


void Pyramid(string with = "1", string on = "3", string some = "2", int count = 4)
{
    if (count > 1) Pyramid(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Pyramid(some, on, with, count - 1);

}


Pyramid();