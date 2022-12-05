// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write($"Введите пятизначное число \n");
//int a = int.Parse(Console.ReadLine()!);
String number = Console.ReadLine()!;
if (number[4] == number[0] & number[3] == number[1]) 
{Console.Write($"число {number} является палиндромом \n");}
else {Console.Write($"число {number} не является палиндромом \n");}
