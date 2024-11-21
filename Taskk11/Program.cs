public class ArrayFromCommandLine
{
    public static void Main(string[] args)
    {
        // Проверка наличия аргумента командной строки
        if (args.Length == 0)
        {
            Console.WriteLine("Ошибка: Не указан размер массива в качестве аргумента командной строки.");
            return;
        }
        // Парсинг размера массива. Обработка ошибок
        if (!int.TryParse(args[0], out int size) || size <= 0)
        {
            Console.WriteLine("Ошибка: Неверный размер массива. Укажите положительное целое число.");
            return;
        }
        // Создание массива и заполнение его значениями (можно изменить на что-то другое)
        int[] myArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            myArray[i] = i + 1; // Заполняем массив числами от 1 до size
        }
        // Вывод массива на консоль
        Console.WriteLine("Массив:");
        Console.Write("[");
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i]);
            if (i < myArray.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}