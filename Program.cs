//DZ 7//
// Задача 47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
void FillArray47(double[,] array)
{
    Random random = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble() * 10 - 5;
        }
    }
}
void PrintArray47(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }
}
void Zadacha47()
{
    Random random = new Random();
    int rows = random.Next(4, 9);
    int columns = random.Next(4, 9);
    double[,] array = new double[rows, columns];
    FillArray47(array);
    PrintArray47(array);
}

// Задача 50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
void FillArray50(int[,] array)
{
    Random random = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 11);
        }
    }
}
void PrintArray50(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void Zadacha50() 
{
    Random random = new Random();
    int rows = random.Next(4, 9);
    int columns = random.Next(4, 9);
    int[,] array = new int[rows, columns];
    FillArray50(array);
    PrintArray50(array);
    Console.WriteLine("Введите позицию искомого элемента");
    int find = Convert.ToInt32(Console.ReadLine());
    if (find > array.Length && find <= 0) Console.WriteLine("Введенный индекс находится за пределами массива");
    else
    {
        int x = (find - 1) / columns;
        int y = (find - 1) % columns;
        Console.WriteLine($"Испрашиваемая позиция находится в {x + 1} строке {y + 1} колонке и имеет значение {array[x, y]}");
    }
}


// Задача 52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
void Zadacha52()
{
    Random random = new Random();
    int rows = random.Next(4, 5);
    int columns = random.Next(4, 5);
    int[,] array = new int[rows, columns];
    FillArray50(array);
    PrintArray50(array);
    for(int j = 0; j < columns; j++)
    {
        double sum = 0;
        for(int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма столбца {j + 1} = {Math.Round(sum / rows, 2)}");
    }
}

