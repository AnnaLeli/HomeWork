// 24 арефметическая прогрессия
/* Console.Clear();

Console.Write("введите число ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((n + 1) / 2 * n); */

/* 



Console.Clear();

Console.Write("введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0
while (a > 0)
{
    a = a / 10;
    count++ 
}

Console.Write(count); */
/*
Console.Clear();

Console.Write("введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 2;
int result = 1;
while (a >= count)
{
    result = result * count;
    count++; 
}
Console.Write(result); */

Console.Clear();

int[] array = new int[8];
int i = 0; 
while (i < array.Length)
{
    array[i] = new Random().Next(0, 2);
    i++;
}
Console.WriteLine("[" + string.Join(" | ", array) + "]");