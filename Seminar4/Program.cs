Console.Clear();

/*Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.*/

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// Console.Write("Введите степень числа: ");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine($"{number} в степени {num}: {GetStepen(num)}");

// int GetStepen (int stepen)
// {
// int result = 1;
// for (int index = 1; index <=stepen; index++)
// {
//     result = result * number;
// }
//     return result;
// }

/*Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.*/

// Console.Write("Введите число: ");
// string numstring = Console.ReadLine();
// int number = int.Parse(numstring);
// Console.WriteLine($"Сумма цифр в числе {number}: {GetSum(numstring.Length)}");

// int GetSum(int limit)
// {
//     int sum = 0;
//     for (int index = 0; index < limit; index++)
//     {
//         int div = Convert.ToInt32(((Math.Pow(10, index))));
//         int num = (number / div) % 10;
//         //Console.WriteLine($"{number} / {div} % 10 = {num}");
//         sum = sum + num;
//     }
//     return sum;
// }

/*Задача 29: Напишите программу, которая задаёт массив 
из 8 рандомных элементов и выводит их на экран.*/

int[] massiv = new int[8];
FillArray(massiv);
Console.Write("Восемь рандомных элементов массива: ");
PrintArray(massiv);

void FillArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(-1000000, 1000000);
    }
}

void PrintArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]} ");
    }
}
