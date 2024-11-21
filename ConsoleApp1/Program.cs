//нарисуйте прямоугольный треугольник звёздочками. чтобы высоту
// треугольника можно было задавать программно. пример:
// a. *
// **
// ***
// ****
// и тд
// b.
// *
// **
// ***
// ****
// и тд
// c.дайте возможность задавать символ для отрисовки программно. т.е.
// вместо звёздочки может быть любой символ.
using System.Linq.Expressions;
using System.Runtime.InteropServices;
[DllImport("msvcrt")]
static extern int _getch();

int var,a;
Console.WriteLine("Программа для рисования прямоугольного треугольника");

string symbol;
void left(string symbol, int a)
{
    for (int i = 1; a != 0; i++, a -= 1)
    {
        Console.WriteLine(String.Concat(Enumerable.Repeat(symbol, i)));
    }  
}

void right(string symbol,int a)
{
    for (int i = 1; a != 0; i++, a -= 1)
    {
        string aa = String.Concat(Enumerable.Repeat(' ', a));
        string ii = String.Concat(Enumerable.Repeat(symbol, i));
        Console.WriteLine($"{aa}{ii}");
    }
}
void custom(char symbol, int a)
{

    Console.WriteLine("Введите желаемый трейгольник \n1 - Левосторонний  \n2 - Правосторонний");
    int varC = _getch();
    if (varC == '1')
    {
        for (int i = 1; a != 0; i++, a -= 1)
        {
            Console.WriteLine(String.Concat(Enumerable.Repeat(symbol, i)));
        }
    }
    else if (varC == '2')
    {
        for (int i = 1; a != 0; i++, a -= 1)
        {
            string aa = String.Concat(Enumerable.Repeat(' ', a));
            string ii = String.Concat(Enumerable.Repeat(symbol, i));
            Console.WriteLine($"{aa}{ii}");
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод");
    }
}

do
{
    Console.WriteLine("Введите Введите 1, 2 или 0\n1 - Левосторонний  \n2 - Правосторонний \n3 - Настраиваемый - \n0 - Выход из программы");
    var = _getch();
    switch (var)
    {
        case ('1'):
            Console.WriteLine("Введите высоту треугольника");
            a = Convert.ToInt32(Console.ReadLine());
            left("*",a);
            break;
        case ('2'):
            Console.WriteLine("Введите высоту треугольника");
            a = Convert.ToInt32(Console.ReadLine());
            right("*",a);
            break;
        case ('3'):
            Console.WriteLine("Введите высоту треугольника");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите желаемый символ(ы)");
            char symbolc = Convert.ToChar(Console.Read());
            custom(symbolc, a);
            break;
        default:
            Console.WriteLine("!!! Введите 1, 2 или 0 !!!");
            break;
    }
} while (var != '0'); Console.WriteLine("0");

