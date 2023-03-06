// имеется уравнение ((4-2)*(1+3))/10
// Обход

string emp = string.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2    3     4    5    6    7    8    9    10   11
void InOrderTraversal(int poss = 1)
{
    if (poss < tree.Length)
    {
        int left = 2 * poss;
        int right = 2 * poss + 1;
        if (left < tree.Length
            && !String.IsNullOrEmpty(tree[left]))
            InOrderTraversal(left);
            Console.WriteLine(tree[poss]);
        if (right < tree.Length
            && !String.IsNullOrEmpty(tree[right]))
            InOrderTraversal(right);
    }
}
InOrderTraversal();
