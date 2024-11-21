using System.Runtime.InteropServices;
[DllImport("msvcrt")]
static extern int _getch();
int var;
Console.WriteLine("Программа для вычисления теоремы Пифагора");
int a, b, c;
do
{
    Console.WriteLine("Введите Введите 1, 2 или 0\n1 - Дано два катета \n2 -Дана гипотенуза и один катет\n0 - Выход из программы");
    var = _getch();
    switch (var)
    {
        case ('1'): 
            Console.WriteLine("Введите первый катет");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй катет");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Гипотенуза = " + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            break;
        case ('2'):
            Console.WriteLine("Введите катет");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите гипотенузу");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Второй Катет = " + Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2)));
            break;
        default:
            Console.WriteLine("!!! Введите 1, 2 или 0 !!!");
            break;
    }
} while (var != '0'); Console.WriteLine("0");

