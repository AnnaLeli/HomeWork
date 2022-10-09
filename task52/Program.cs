// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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
Console.WriteLine("Среднее арифметические каждого столбца: ");

for (int i = 0; i < matrix.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[j, i]; 
        }
        double mid = sum / matrix.GetLength(0); 
    Console.Write(mid + " ");
}
