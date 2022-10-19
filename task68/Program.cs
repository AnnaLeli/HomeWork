// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(m, n));

int Akkerman(int m, int n)
{
   if (m == 0)
      return n + 1;
    else if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
        else
            return Akkerman(m - 1, Akkerman(m, n - 1)); 
}