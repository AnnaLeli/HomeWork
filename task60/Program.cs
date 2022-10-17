// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            matrix[i, j, k] = new Random().Next(0,11);
            Console.WriteLine(matrix[i, j, k] + "(" + i + "," + j + "," + k + ")");
            }
        }
    }
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во строчек третьего измерения: ");
int a = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[n, m, a];
InputMatrix(matrix);