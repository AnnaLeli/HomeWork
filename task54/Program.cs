void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0,100);
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);

void SortArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int f = 0; f < matrix.GetLength(1) - 1; f++)
            {
            if(matrix[i,f] < matrix[i, f + 1])
            {
                int temp = matrix[i, f + 1];
                matrix[i, f + 1] = matrix[i, f];
                matrix[i, f] = temp;
            }
            }
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
SortArray(matrix);

