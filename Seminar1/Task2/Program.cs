/*Напишите программу, которая на вход принимает два числа и 
выдаёт, какое число большее, а какое меньшее.*/

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int max = 0;
if (num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}

Console.WriteLine($"Максимальное число: {max} ");
