public class LeapYearCalculator
{
    public static void Main(string[] args)
    {
        Console.Write("Введите год: ");

        // Важно:  Обработка возможных ошибок ввода.
        if (!int.TryParse(Console.ReadLine(), out int year))
        {
            Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите целое число.");
            return;
        }


        if (year <= 0)
        {
            Console.WriteLine("Ошибка: Пожалуйста, введите положительное целое число.");
            return;
        }


        // Проверка условий високосности
        if (year % 400 == 0)
        {
            Console.WriteLine($"{year} - високосный год.");
        }
        else if (year % 100 == 0)
        {
            Console.WriteLine($"{year} - не високосный год.");
        }
        else if (year % 4 == 0)
        {
            Console.WriteLine($"{year} - високосный год.");
        }
        else
        {
            Console.WriteLine($"{year} - не високосный год.");
        }
    }
}