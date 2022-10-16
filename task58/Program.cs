void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,11);
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[n, m];
Console.WriteLine("Первая матрица: ");
InputMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = new int[n, m];
Console.WriteLine("Вторая матрица: ");
InputMatrix(matrix2);
Console.WriteLine();

void Result(int[,] matrix1, int[,] matrix2)
{
int[,] matrixResult = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrixResult[i, j] = matrix1[i,j] * matrix2[i,j];
        
        Console.Write(matrixResult[i, j] + " \t");
        }
    Console.WriteLine();
    }
}
Console.WriteLine("перемноженные матрицы");
Result(matrix1, matrix2);