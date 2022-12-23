// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на
// выходе показывает вторую цифру этого числа.

using static System.Console;
WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(ReadLine());
int a = number % 100;
int b = a / 10;
WriteLine(b);