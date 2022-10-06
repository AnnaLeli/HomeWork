// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();


void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(0, 100);
}

int Chet(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int t = array[i] % 2;
        if (t == 0)
        count++;
    }
    return count;
}

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Chet(array);
Console.WriteLine("чётных элементов: ");
Console.WriteLine(Chet(array));