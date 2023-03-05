// Увеличить каждую из координат в 2 раза
// и показать вывод
using System.Linq;

// возьмите текс    
string text = "(1,2) (2,3) (4,5) (7,7)"
                .Replace("(", "")  // замените в нем скобочки
                .Replace(")", "")  // замените в нем скобочки
                ;
Console.WriteLine(text);
//возьми текс    разбей этим разделителем будет пробел
var data = text.Split(" ")
                .Select(item => item.Split(',')) //сделай выборку таких элементов и разбить забятой
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))// сделай выборку ,где перв коорд массива х, конвертирована в число
                .Where(e => e.x % 2 == 0)// проверка условия, дайте пары, где перв коорд четная
                .Select(point => (point.x * 10, point.y + 10))// дайте набор из предыд этапа и для него увелич коорд
                .ToArray();// превратить в массив

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    //Console.WriteLine(data[i].x*10);
    // for (int k = 0; k < data[i].Length; k++)
    // {
    //     //Console.WriteLine(data[i][k]);
    // }
    // Console.WriteLine();
}