Console.Clear();

/*Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите степень числа: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{number} в степени {num}: {GetStepen(num)}");

int GetStepen (int stepen)
{
int result = 1;
for (int index = 1; index <=stepen; index++)
{
    result = result * number;
}
    return result;
}
/*Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.*/


