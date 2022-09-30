Console.Clear();

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

// int[] massiv = new int[1000];
// FillArray(massiv);

// Console.Write("Массив: ");
// PrintArray(massiv);
// Console.WriteLine();

// Console.Write("Количество чётных элементов массива: ");
// Counter(massiv);


// void FillArray(int[] array)
// {
//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = new Random().Next(100, 1000);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int index = 0; index < array.Length; index++)
//     {
//         Console.Write($"{array[index]} ");
//     }
// }

// void Counter(int[] array)
// {
//     int count = 0;
//     for (int index = 0; index < array.Length; index++)
//     {
//         if (array[index] % 2 == 0)
//         {
//             count = count + 1;
//         }
//     }
//     Console.Write(count);
// }

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/

int[] massiv = new int [100];
FillArray(massiv);

Console.Write("Массив: ");
PrintArray(massiv);

Console.WriteLine();
Console.Write("Сумма нечётных элементов массива: ");
Summa(massiv);

void FillArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(-99, 100);
    }
}

void PrintArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]} ");
    }
}

void Summa(int[] array)
{
    int sum = 0;
    for (int index = 1; index < array.Length; index ++)
    {
        //Console.Write($"{array[index]} ");
        sum = sum + array[index];
        index++;
    }
    Console.Write(sum);
}
