Console.Clear();

/*Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.*/

// Console.Write("Количество строк: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Количество столбцов: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(columns, rows, -99, 100);
// Console.WriteLine("Двумерный массив: ");
// PrintArray(array);

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

// int rows = 5;
// int columns = 10;
// Console.WriteLine($"Количество строк: {rows}");
// Console.WriteLine($"Количество столбцов: {columns}");

// int[,] array = GetArray(columns, rows, -99, 100);
// Console.WriteLine("Двумерный массив: ");
// PrintArray(array);

// for (int count = 0; count < 5; count++)
// {
//     Console.Write("Номер столбца: ");
//     int i = int.Parse(Console.ReadLine());

//     Console.Write("Номер строки: ");
//     int j = int.Parse(Console.ReadLine());

//     if (i >= columns || j >= rows)
//     {
//         Console.WriteLine("Такого элемента нет");
//     }
//     else
//     {
//         Console.WriteLine($"Значение элемента: {array[i, j]}");
//     }
// }

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.*/

int rows = 40;
int columns = 15;
Console.WriteLine($"Количество строк: {rows}");
Console.WriteLine($"Количество столбцов: {columns}");

int[,] array = GetArray(columns, rows, -9, 10);
Console.WriteLine("Двумерный массив: ");
PrintArray(array);

Console.Write("Среднее арифметическое в каждом столбце соответственно:");
for (int i = 0; i < array.GetLength(0); i++)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = array[i, j] + sum;
    }
    Console.SetCursorPosition(i * 4, rows + 4);
    if (sum >= 0) Console.Write(" ");
    Console.Write(sum / rows);
}

int[,] GetArray(int n, int m, int minValue, int maxValue)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {

            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.SetCursorPosition(i * 4, j + 3);
            if (array[i, j] >= 0) Console.Write(" ");
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}

