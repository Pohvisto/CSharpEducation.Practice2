using System;

public class RandomArray
{
    public static void Main(string[] args)
    {
        // Запрос размера массива у пользователя
        Console.Write("Введите размер массива: ");
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Неверный размер массива. Пожалуйста, введите положительное целое число.");
            return;
        }

        // Создание массива с помощью метода
        int[] randomArray = CreateRandomArray(size);

        // Вывод массива с помощью метода
        PrintArray(randomArray);
    }

    // Метод для создания массива случайных чисел
    public static int[] CreateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 101); // Генерация случайных чисел от 1 до 100 (включительно)
        }
        return array;
    }

    // Метод для вывода массива на консоль
    public static void PrintArray(int[] array)
    {
        Console.Write("Массив: [");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}