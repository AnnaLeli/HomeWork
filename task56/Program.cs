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


int[] Sum(int [,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];  
        }
    }
    return sum;
}

int[] sum = Sum(matrix);

void Result(int[] sum)
{
    int min = sum[0];
    int row = 1;
    for (int i = 1; i < sum.Length; i++)
        {
            if (sum[i] < min)
            {
            min = sum[i];
            row = i + 1;
            }
        }
    Console.WriteLine($"строка с минимальной суммой элементов: {row}");
    Console.WriteLine($"строка с минимальной суммой элементов: {min}");
}


Result(sum);