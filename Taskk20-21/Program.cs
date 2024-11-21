public class DaysOfWeek
{
    public static void Main(string[] args)
    {
        // Вывод названий дней недели
        string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        Console.WriteLine("Дни недели:");
        for (int i = 0; i < days.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {days[i]}");
        }

        // Считывание ввода пользователя и вывод соответствующего дня недели
        Console.Write("Введите номер дня недели (1-7): ");
        if (int.TryParse(Console.ReadLine(), out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine($"Выбранный день недели: {days[dayNumber - 1]}");
        }
        else
        {
            Console.WriteLine("Ошибка: Неверный номер дня недели.");
        }
    }
}