Console.Clear();

int[,] array = GetArray(10, 20, -99, 100);
int distanceBetweenColumns = 6;
int indentArray = 1;
Console.WriteLine("Двумерный массив: ");
PrintArray(array);

/*Задача 54: Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.*/

Console.WriteLine("Упорядоченный массив: ");
int minValue = -999999;
DecreasingArray(array);

void DecreasingArray(int[,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = minValue;
            int index = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                    index = i;
                }
            }
            Console.SetCursorPosition(x * distanceBetweenColumns, j + array.GetLength(1) + indentArray * 2);
            if (max >= 0) Console.Write(" ");
            Console.WriteLine(max);
            array[index, j] = minValue;
        }
    }
}

int[,] GetArray(int columns, int rows, int minValue, int maxValue)
{
    int[,] array = new int[columns, rows];
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
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
            Console.SetCursorPosition(i * distanceBetweenColumns, j + indentArray);
            if (array[i, j] >= 0) Console.Write(" ");
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}