// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
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

Console.Write("Введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int j = Convert.ToInt32(Console.ReadLine());

if (i > matrix.GetLength(0) || j > matrix.GetLength(1))
Console.Write("Такого элемента нет");
else 
Console.Write(matrix[i - 1, j - 1]);
   