Console.Clear();
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.*/
// Console.Write("Введите трёхзначное число: ");
// int number = int.Parse(Console.ReadLine());

// int num1 = number / 10;
// int num2 = num1 % 10;

// Console.Write($"Вторая цифра этого числа: {num2}");

/*Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.*/
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number < 100) Console.Write("Третьей цифры нет");
else if (number < 1000)
    Console.Write($"Третья цифра этого числа: {number % 10}");
else if (number < 10000)
{
    int num1 = number / 10;
    Console.Write($"Третья цифра этого числа: {num1 % 10}");
}
else if (number < 100000)
{
    int num1 = number / 100;
    Console.Write($"Третья цифра этого числа: {num1 % 10}");
}
else Console.Write("Число слишком большое");
