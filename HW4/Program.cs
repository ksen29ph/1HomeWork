// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число, чтобы увидеть все четные числа в диапозоне от 1 до вашего числа");
int b = int.Parse(Console.ReadLine());
int a = 1;
for (int i = a; i <= b; i++)
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " ");
    }
Console.ReadKey();