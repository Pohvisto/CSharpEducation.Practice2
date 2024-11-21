string a;
char b;

void foreh(string aa, char bb)
{
    float qwe = 0;
    float iqwe = 0;
    foreach (char c in aa)
    {
        qwe += 1;
        if (c == bb)
        {
            iqwe += 1;

        }

    }
    Console.WriteLine(iqwe / qwe);
}

//1
a = "135423121";
b = '1';
foreh(a,b);
//2
Console.WriteLine("Введите текст");
a = Console.ReadLine();
Console.WriteLine("Введите символ ");
b = Convert.ToChar(Console.ReadLine());
foreh(a, b);
//3 NO
