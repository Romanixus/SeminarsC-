Console.Clear();
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.*/
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

int num1 = number / 10;
int num2 = num1 % 10;

Console.Write($"Вторая цифра этого числа: {num2}");