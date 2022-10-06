//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();


void InputArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().NextDouble() * 10;
}

double Delta(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) 
        max = array[i];
        else if (array[i] < min) 
        min = array[i];
    }
    double del = max - min;
    return del;
}

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Delta(array);
Console.WriteLine("разница между максимальным и минимальным элементами массива: ");
Console.WriteLine(Delta(array));