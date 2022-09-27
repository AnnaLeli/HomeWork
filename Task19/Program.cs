
Console.Clear();

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 10000 || n > 99999)
{
    Console.Write("Введите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}


    int Start = n / 1000;
    int Finish = n % 100;

if (Start / 10 == Finish % 10 && Start % 10 == Finish / 10)
    Console.Write("yes");
else 
    Console.Write("no");