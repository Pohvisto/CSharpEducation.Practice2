Console.WriteLine("программа для вычисления выражения (а + b — f / а) + f * a * a — (a + b)");
float a, b, f,c;
Console.WriteLine("Введите a");
a = float.Parse(Console.ReadLine());
Console.WriteLine("Введите b");
b = float.Parse(Console.ReadLine());
Console.WriteLine("Введите f");
f = float.Parse(Console.ReadLine());
if (a != 0)
{
    Console.WriteLine($"Получилось: {(a + b - (f / a)) + (f * a * a) - (a + b)}");
}
