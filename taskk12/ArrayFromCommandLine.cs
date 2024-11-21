public class ArrayFromCommandLine
{
    public static void Main(string[] args)
    {
        // Проверка наличия аргументов командной строки
        if (args.Length < 2)
        {
            Console.WriteLine("Ошибка: Не указан размер массива или число для заполнения в качестве аргумента командной строки.");
            return;
        }

        // Парсинг размера массива. Обработка ошибок
        if (!int.TryParse(args[0], out int size) || size <= 0)
        {
            Console.WriteLine("Ошибка: Неверный размер массива. Укажите положительное целое число.");
            return;
        }

        // Парсинг числа для заполнения массива. Обработка ошибок
        if (!int.TryParse(args[1], out int fillValue))
        {
            Console.WriteLine("Ошибка: Неверное число для заполнения массива. Укажите целое число.");
            return;
        }

        // Создание массива и заполнение его значениями
        int[] myArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            myArray[i] = fillValue;
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