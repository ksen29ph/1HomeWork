// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число и узнаете является ли оно четным:");

int a = Convert.ToInt32(Console.Read());
if (a % 2 == 0)
Console.WriteLine("Четное число");
else
Console.WriteLine("Нечетное число");
 Console.ReadKey();