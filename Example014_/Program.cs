// string[,] table = new string[2, 5];
// //String.Empty; - инициализация строки;
// //table [0,0] table [0,1] table [0,2] table [0,3] table [0,4] 
// //table [1,0] table [1,1] table [1,2] table [1,3] table [1,4] 

// table[1, 2] = "первое строка,второе столбец";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }


   Console.Clear();

void PrintArray(int[,] matr)
{
    // int[,] matr = new int[3, 4]; // простая инициализация 2массива с любыми входными данными;

    for (int rows = 0; rows < matr.GetLength(0); rows++) // rows< matrix.GetLength(0)= 0 колл-во string
    {
        for (int colums = 0; colums < matr.GetLength(1); colums++)
        {
            Console.Write($"{matr[rows, colums]}");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int colums = 0; colums < matr.GetLength(1); colums++)
        {
            matr[rows, colums] = new Random().Next(1, 10);//
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);