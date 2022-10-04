Console.Clear();
Console.WriteLine("Введи число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("в какую степень возвести число? ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result = 1;
while (count <= n)
{
    result = result * a;
    count++;
}
Console.WriteLine(result);