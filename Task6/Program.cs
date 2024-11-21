int a, b;
a = 0;
while (a != '1')
    {
    Console.WriteLine("Введите первое число");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    b = Convert.ToInt32(Console.ReadLine());
    if (a > b)
    {
        Console.WriteLine($"Ответ: {a} > {b}");
    }
    else if (a < b)
    {
        Console.WriteLine($"Ответ: {a} < {b}");
    }
    else
    {
        Console.WriteLine($"Ответ: {a} = {b}");
    }
}