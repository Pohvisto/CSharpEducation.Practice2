//a
using System;

Console.WriteLine("\n!!! for(a<3) !!!\n");
for (int a = 0; a < 3; a++, Console.WriteLine($"for(a)= {a}")) { }

//b
int b = 0;
Console.WriteLine("\n!!! while(b!=5) !!!\n");
while (b != 5) 
    { 

    Console.WriteLine($"while(b)= {b += 1}");
}
//c
int c = 14;
Console.WriteLine("\n!!! dowhile(c>10) !!!\n");
do
{
    Console.WriteLine($"for(c)= {c -= 1}");
} while (c > 10);

//d
Console.WriteLine("1.d");
string dd = "";
for (string d =""; d != "0";)
{
    Console.WriteLine("Введите слово, для выхода  введите 0");
    d = Console.ReadLine();
    dd +=" " + d;
    Console.WriteLine($"Вы ввели: {dd}");
}
//e 
Console.WriteLine("1.e");
string e, ee;
e = ee = "";
while (e != "0")
{

    Console.WriteLine("Введите слово, для выхода  введите 0");
    e = Console.ReadLine();
    ee += " " + e;
    Console.WriteLine($"Вы ввели: {ee}");
}
//f
Console.WriteLine("1.f");
string f, ff;
f = ff = "";
do
{
    Console.WriteLine("Введите слово, для выхода  введите 0");
    f = Console.ReadLine();
    ff += " " +f;
    Console.WriteLine($"Вы ввели: {ff}");
} while (f != "0");