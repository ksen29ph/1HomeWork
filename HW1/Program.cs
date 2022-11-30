// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите 2 числа, чтобы узнать большее из них");
int a, b;
Console.WriteLine("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

 if(a > b)
{
Console.WriteLine("Первое число больше второго");
}
else if (a < b)
 {
Console.WriteLine("Второе число больше первого");
}
else
{
Console.WriteLine("Числа равны");
}
Console.ReadKey();
