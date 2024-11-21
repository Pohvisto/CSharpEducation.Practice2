using System;

public class GuessTheNumber
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Генерация случайного числа от 1 до 100
        int maxAttempts = 10;
        int attempts = 0;
        int guess;

        Console.WriteLine("Добро пожаловать в игру \"Угадай число\"!");
        Console.WriteLine("Я загадал число от 1 до 100. У вас есть " + maxAttempts + " попыток.");

        while (attempts < maxAttempts)
        {
            attempts++;
            Console.Write("Попытка " + attempts + ": Введите ваше число: ");

            if (int.TryParse(Console.ReadLine(), out guess))
            {
                if (guess == secretNumber)
                {
                    Console.WriteLine("Поздравляю! Вы угадали число " + secretNumber + " за " + attempts + " попыток!");
                    return;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введите целое число.");
                attempts--; // Не считаем некорректный ввод как попытку
            }
        }

        Console.WriteLine("Вы исчерпали все попытки. Загаданное число было " + secretNumber + ".");
    }
}