// : Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.


using static System.Console;
WriteLine("Введите число");
int dayw = Convert.ToInt32(ReadLine());
WriteLine(dayw == 6? "Да" : dayw == 7? "Да":"Нет" );