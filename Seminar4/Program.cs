Console.Clear();

/*Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите степень числа: ");
int num = int.Parse(Console.ReadLine());

int result = 1;
for (int index = 1; index <=num; index++)
{
    result = result * number;
}

Console.WriteLine($"{number} в степени {num}: {result}");
