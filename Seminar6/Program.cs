Console.Clear();
/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

Console.Write("Введите количество чисел: ");
int M = int.Parse(Console.ReadLine());

int count = 0;
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите {i + 1}-е число: ");
    int num = int.Parse(Console.ReadLine());
    if (num > 0)
    {
        count = count + 1;
    }
}
Console.Write($"Количество чисел больше 0: {count}");