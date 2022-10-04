int[] array = new int[8];
int i = 0;
while (i < array.Length)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

Console.WriteLine("[" + string.Join(" | ", array) + "]");