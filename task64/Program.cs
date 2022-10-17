// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


void InputMatrix(int[,] matrix)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix [i,j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else 
            i--;
    }
}



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        matrix[0, 0] = 1;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}

Console.Clear();
Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
Console.WriteLine();
InputMatrix(matrix);
PrintMatrix(matrix);
