Console.Clear();

// int[,] array = GetArray(10, 20, -99, 100);
// int distanceBetweenColumns = 6; //Расстояние между столбцами
// int indentArray = 1; //Расстояние перед массивом
// Console.WriteLine("Двумерный массив: ");
// PrintArray(array);

/*Задача 54: Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.*/

// Console.WriteLine("Упорядоченные элементы: ");
// int minValue = -999999; //Минимальное число в массиве (меньше можно, больше нельзя)
// int[,] minValues = (int[,])array.Clone(); //Копия массива, в которой все элементы будут minValue
// DecreasingArray(minValues); 

// void DecreasingArray(int[,] minValues) 
// {
//     for (int row = 0; row < minValues.GetLength(0); row++) //Переход на следующий ряд
//     {
//         for (int j = 0; j < minValues.GetLength(1); j++)
//         {
//             int max = minValue;
//             int index = 0;
//             for (int i = 0; i < minValues.GetLength(0); i++)
//             {
//                 if (minValues[i, j] > max)
//                 {
//                     max = minValues[i, j];
//                     index = i;
//                 }
//             }
//             Console.SetCursorPosition(row * distanceBetweenColumns, j + minValues.GetLength(1) + indentArray * 2);
//             if (max >= 0) Console.Write(" ");
//             Console.WriteLine(max);
//             minValues[index, j] = minValue; // Уменьшение максимального элемента в ряду
//         }
//     }
// }

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/

// int minSum = 0; //Значение должно быть больше, чем у строки с наименьшей суммой элементов
// int minSumRow = 0;

// for (int j = 0; j < array.GetLength(1); j++)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum = sum + array[i, j]; //Складываем все элементы строки
//     }
//     Console.SetCursorPosition(array.GetLength(0) * distanceBetweenColumns, j + indentArray);
//     Console.Write("|");
//     if (sum >= 0) Console.Write(" ");
//     Console.WriteLine(sum);
//     if (sum < minSum) //Находим строку с наименьшей суммой элементов
//     {
//         minSum = sum;
//         minSumRow = j;
//     }
// }

// Console.WriteLine($"Номер строки с наименьшей суммой элементов ({minSum}): {minSumRow}*");
// Console.Write("*строки номируются с нуля");

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

int[,] matrix1 = GetArray(2, 2, 0, 5);
int[,] matrix2 = GetArray(2, 2, 0, 5);
int[,] matrix3 = GetArray(2, 2, 0, 10);

Console.WriteLine("Первая матрица: ");
PrintArray(matrix1);
Console.WriteLine("Вторая матрица: ");
PrintArray(matrix2);

 matrix3[0, 0] = matrix1[0, 0] * matrix2[0, 0] + matrix1[1, 0] * matrix2[0, 1];
 matrix3[1, 0] = matrix1[0, 0] * matrix2[1, 0] + matrix1[1, 0] * matrix2[1, 1];
 matrix3[0, 1] = matrix1[0, 0] * matrix2[0, 1] + matrix1[0, 1] * matrix2[1, 1];
 matrix3[1, 1] = matrix1[0, 1] * matrix2[1, 0] + matrix1[1, 1] * matrix2[1, 1];

Console.WriteLine("Произведение двух матриц: ");
PrintArray(matrix3);


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
            // Console.SetCursorPosition(i * distanceBetweenColumns, j + indentArray);
            if (array[i, j] >= 0) Console.Write(" ");
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}