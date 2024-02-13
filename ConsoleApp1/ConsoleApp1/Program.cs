Console.WriteLine("Введіть перше число:");
string input1 = Console.ReadLine();

Console.WriteLine("Введіть друге число:");
string input2 = Console.ReadLine();

// Конвертуємо введені значення у числа
if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
{
    // Обчислюємо суму
    double sum = number1 + number2;

    // Виводимо результат
    Console.WriteLine($"Сума {number1} і {number2} дорівнює {sum}");
}
else
{
    Console.WriteLine("Неправильний формат введених даних. Будь ласка, введіть числа.");
}