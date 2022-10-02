// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] FillArray(int size)
{
    double[] mas = new double[size];

    for (int i = 0; i < size; i++)
    {
        mas[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
    return mas;
}

void PrintArray(double[] mmm)
{
    for (int i = 0; i < mmm.Length; i++)
    {
        if (i != mmm.Length - 1) Console.Write($"{mmm[i]}, ");
        else Console.WriteLine($"{mmm[i]}");
    }
}

try
{
    System.Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = FillArray(size);
    PrintArray(array);

    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int z = 0; z < array.Length; z++)
    {
        if (array[z] > max)
        {
            max = array[z];
        }
        if (array[z] < min)
        {
            min = array[z];
        }
    }

    Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}

catch
{
    Console.WriteLine("Надо было вводить целое число!");
}