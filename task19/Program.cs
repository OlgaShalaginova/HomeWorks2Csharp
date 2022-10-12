// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int x1 = number/10000;
int x2 = (number/1000)%10;
int x3 = (number/100)%10;
int x4 = (number/10)%10;
int x5 = (number%10);
if (x1 == x5 && x2 == x4) 
{
    Console.WriteLine("Это число палиндром");
}
else
{
    Console.WriteLine("Это число не палиндром");
}