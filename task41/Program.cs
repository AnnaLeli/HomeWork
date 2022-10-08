// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

void InputArray(int[] array)
{
for (int count = 0; count < array.Length; count++)
{
    Console.Write("введи число: ");
    array[count] = Convert.ToInt32(Console.ReadLine());
}
}

Console.Write("Сколько будет чисел? ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
int result = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    result = result + 1;
}
Console.Write(result);
