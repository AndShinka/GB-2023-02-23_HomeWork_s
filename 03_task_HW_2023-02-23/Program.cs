// 3. Найти сумму цифр числа
// 03_task_HW_2023-02-23

int ReadNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumDigits(int number)
{
    if (number < 1) return 0;
        return SumDigits(number / 10) + number % 10;
}

Console.Clear();
Console.WriteLine();
Console.WriteLine("Задача: Найти сумму цифр числа." !);
int number = ReadNum("Введите число:"!);

Console.WriteLine();

Console.WriteLine($"Сумма цифр числа равна : {SumDigits(number)}" !);
Console.WriteLine();
