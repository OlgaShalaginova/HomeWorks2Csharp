﻿/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число");
double n = double.Parse(Console.ReadLine()!);
for( int i =1; i <=n; i ++)
{
     double cube = Math.Pow(i, 3);
    Console.WriteLine($"Куб числа {i} равен {cube}");
}