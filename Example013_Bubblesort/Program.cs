
int[] arr = { 8, 7, 4, 6, 5, 1, 3, 2, 4 };

void PrintArray(int[] array)
{

    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionArray(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minelement = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minelement]);
            minelement = j;
        }
        int temp = array[i];
        array[i] = array[minelement];
        array[minelement] = temp;
    }
}
PrintArray(arr);
SelectionArray(arr);
PrintArray(arr);