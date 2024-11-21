 static string ToLower(string str)
{
    Console.WriteLine(str.ToLower());
    return str.ToLower();
}
 static string ToUpper(string str)
{
    Console.WriteLine(str.ToUpper());
    return str.ToUpper();
}
static string ToTitleCase(string str)
{
    string c =  System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
    Console.WriteLine(c);
    return c;

}
string a, b;
a = "sdpko sfdasd";
b = "MWFEMLPLSDCS";
ToUpper(a);
ToLower(b);
ToTitleCase(a);

