/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите координату Х точки А");
double ax = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А");
double ay = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А");
double az = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Х точки B");
double bx = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
double by = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B");
double bz = double.Parse(Console.ReadLine());
double n = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
Console.WriteLine($"Расстояние между точками А и В равно: {Math.Round(n, 2)}");