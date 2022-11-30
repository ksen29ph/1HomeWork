// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 3 любых числа и узнаете максимальное из них");

int a, b, c;
Console.WriteLine("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;
{
Console.WriteLine(max + " - максимальное число");
Console.ReadKey();
}