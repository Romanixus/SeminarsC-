/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.*/

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int num = 1;
Console.Write($"Чётные числа от 1 до {N}: ");
while (num <= N)
{
    if (num % 2 == 0)
    {
        Console.Write($"{num} ");
    }
    num++;
}
