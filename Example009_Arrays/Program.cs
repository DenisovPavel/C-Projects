int[] Array = { 1, 44, 67, 89, 33, 67, 98, 21, 56, 78, 3, 2, 6, 78, 99, 75, 3, 5, 7 };

int n = Array.Length;
int find = 75;

int index = 0;

while (index < n)
{
    if (Array[index] == find)
    {
        Console.WriteLine(index);
        // если элементов несколько одинаковых , а нужно найти только первый то можно после нахождения 1-го поставить Break
        // таким образов мы прирвем цикл далее;
    }
    index++;
}