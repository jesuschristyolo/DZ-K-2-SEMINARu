// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

using static System.Console;
WriteLine("Введите число");
int number = Convert.ToInt32(ReadLine());
if (number < 100)
{
    WriteLine("Третьей цифры нет");
}
else
{
int a = number % 1000;
int b = a / 100;
WriteLine(b);
}