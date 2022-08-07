// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N, кратные трём.
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
if (N>M)
for (int i = M; i <= N; i++)
    if (i%3==0)
    Console.Write($" {i}");
else
    for (int j = N; j <= M; j++)
        if (j%3==0)
        Console.Write($" {j}");
