//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


class Program {
    static void Main(string[] args) {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine()!);

        int sum = 0;
        while (number > 0) {
            sum += number % 10; // добавляем к сумме последнюю цифру числа
            number /= 10; // удаляем последнюю цифру числа
        }

        Console.WriteLine($"Сумма цифр числа равна {sum}");
    }
}
