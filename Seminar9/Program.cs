Console.Clear();

/*Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.*/

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());

// Console.Write(NaturalNumbers(n));

int NaturalNumbers(int number)
{
    if (number == 1) return (number);
    Console.Write(number + " ");
    return NaturalNumbers(number - 1);
}

/*Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.*/

Console.Write("Введите минимальное число: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное число: ");
int n = int.Parse(Console.ReadLine());

int sum = 0;
Console.Write($"Сумма элементов в промежутке между числами {m} и {n}: ");
Console.Write(SumNaturalElements(m, n));

int SumNaturalElements(int minValue, int maxValue)
{
    if (minValue > maxValue) return (sum);
    sum = sum + minValue;
    return SumNaturalElements(minValue + 1, maxValue);
}

/*Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.*/
