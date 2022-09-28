/*Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/
/*
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int num1 = number / 10000 % 10;
int num2 = number / 1000 % 10;
int num4 = number / 10 % 10;
int num5 = number % 10;
int no = number / 10000;

if (num1 == num5 && num2 == num4){
    Console.WriteLine($"{number} - палиндром");
}
else if (no < 1 || no > 9) {
    Console.WriteLine("Это не пятизначное число");
}
else {
    Console.WriteLine($"{number} - не палиндром");
}
*/

/*Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
Console.Write("Введите координаты точки X1: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Y1: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Z1: ");
int z = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Z2: ");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x,2) + Math.Pow(y2-y,2) + Math.Pow(z2-z,2));
Console.WriteLine($"result = {result:f3}");
*/

/*Задача 23.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/*
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++){
    double result = Math.Pow(i, 3);
    Console.Write($"{result} ");
}
*/