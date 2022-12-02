// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
var i = Convert.ToInt32(Console.ReadLine());

var x1 = i / 10000;
var x2 = i / 1000 % 10;
var y2 = i % 100 / 10;
var y1 = i % 10;

if(x1 == y1 && x2 == y2)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
