// new int[10] - сщдай новый массив, в которм будет 10 элементов
//FillArray - наименование нашему методу
// метод void - который не возвращает значение

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];
FillArray(array);
array[4] = 7;
array[5] = 7;
PrintArray(array);

Console.WriteLine();

int poss = IndexOf(array, 32);
Console.WriteLine(poss);

