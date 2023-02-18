/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

System.Console.WriteLine("Введите пятизначное число");
string? znach = Console.ReadLine();

if (znach.Length < 5 || znach.Length > 5)
{
    System.Console.WriteLine("Число не пятизначное");
} 
    else if (znach[0] == znach[4] && znach[1] == znach[3])
{
    System.Console.WriteLine("да");
}
    else
{
    System.Console.WriteLine("нет");
}