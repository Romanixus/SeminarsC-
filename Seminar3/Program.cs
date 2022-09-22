Console.Clear();

/*Задача 19. Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.*/

// Console.Write("Введите пятизначное число: ");
// int number = int.Parse(Console.ReadLine());

//     int num1 = number / 10000;
// int num2 = (number / 1000) % 10;
// int num4 = (number % 100) / 10;
// int num5 = number % 10;

// // Console.Write(num1);
// // Console.Write(num2);
// // Console.Write(num4);
// // Console.Write(num5);

// if (number < 10000 || number > 99999) Console.Write("Число не пятизначное");
// else if (num1 == num5 && num2 == num4) Console.Write("Да, число является палиндромом");
//      else Console.Write("Нет, число не является палиндромом");

/*Задача 21. Напишите программу, которая принимает на вход координаты
двух точеки находит расстояние между ними в 3D пространстве.*/

Console.Write("Введите координату х точки А: ");
int Ax = int.Parse(Console.ReadLine());
Console.Write("Введите координату y точки А: ");
int Ay = int.Parse(Console.ReadLine());
Console.Write("Введите координату z точки А: ");
int Az = int.Parse(Console.ReadLine());

Console.Write("Введите координату х точки B: ");
int Bx = int.Parse(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
int By = int.Parse(Console.ReadLine());
Console.Write("Введите координату z точки B: ");
int Bz = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(Bx-Ax,2)+Math.Pow(By-Ay,2)+Math.Pow(Bz-Az,2));
Console.WriteLine($"Расстояние между точками А и В: {result:f2}");
