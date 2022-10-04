Console.Clear();
/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

// Console.Write("Введите количество чисел: ");
// int M = int.Parse(Console.ReadLine());

// int count = 0;
// for (int i = 0; i < M; i++)
// {
//     Console.Write($"Введите {i + 1}-е число: ");
//     int num = int.Parse(Console.ReadLine());
//     if (num > 0)
//     {
//         count = count + 1;
//     }
// }
// Console.Write($"Количество чисел больше 0: {count}");

/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.Write($"Точка пересечения: ({x}; {y})");