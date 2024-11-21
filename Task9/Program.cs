public class CompareVariables
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите три числа(по очереди без пробелов):");
        double num1, num2, num3;
        if (!double.TryParse(Console.ReadLine(), out num1) ||
            !double.TryParse(Console.ReadLine(), out num2) ||
            !double.TryParse(Console.ReadLine(), out num3))
        {
            Console.WriteLine("Ошибка ввода. Введите числа.");
            return;
        }


        if (num1 == num2 || num1 == num3 || num2 == num3)
        {
            num1 *= 5;
            num2 *= 5;
            num3 *= 5;
            Console.WriteLine($"Числа после умножения на 5: {num1}, {num2}, {num3}");
        }
        else
        {
            Console.WriteLine("Равных нет");
        }
    }
}