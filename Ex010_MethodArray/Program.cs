// // Есть одномерный массив array из n элементов
// найти элемент массива, равный find
// 1.Установить счетчик index в позиции 0
// 2.Если array[index]=find, алгоритм завершил работу успешно
// 3.Увеличить index на 1
// Если index<n, то перейти к шагу 2. В противном случае 
// алгоритм завершил работу безуспешно
int[] array = { 1, 4, 65, 34, 93, 23, 6, 21, 7, 23 };
int n = array.Length;
int find = 23;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}
