Console.Clear();

/*Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.*/

Console.Write("Количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, -99, 100);
Console.WriteLine("Двумерный массив: ");
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
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