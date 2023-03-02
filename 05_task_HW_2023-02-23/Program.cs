// 5. Написать программу возведения числа А в целую стень B
// 05_task_HW_2023-02-23

int ReadNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int DegreeOfNumber(int numberA, int numberB)
{
    if (numberB < 1) return 1;
    return numberA * (DegreeOfNumber(numberA, numberB - 1));
}

Console.Clear();
Console.WriteLine("Задача: возвести число А в целую стень B." !);
int numberA = ReadNum("Введите число А:"!);
int numberB = ReadNum("Введите число B:"!);

Console.WriteLine();

Console.WriteLine($"Число {numberA} в степени {numberB} равно: {DegreeOfNumber(numberA, numberB)}" !);
Console.WriteLine();




