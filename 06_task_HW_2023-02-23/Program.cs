// 6. Написать программу показывающие первые N чисел,
//  для которых каждое следующее равно сумме двух предыдущих. 
//  Первые два элемента последовательности задаются пользователем
// 06_task_HW_2023-02-23

int ReadNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int Metod(int x, int y, int num)
{
    if (num == 1) return x;
    if (num == 2) return y;
    return Metod(x, y, num - 1) + Metod(x, y, num - 2);
}

Console.Clear();
int N = 10;
Console.WriteLine($"Задача: Показать первые N чисел, каждое следующее из которых равно сумме двух предыдущих (N = {N})." !);
int numberA = ReadNum("Введите первое число:"!);
int numberB = ReadNum("Введите второе число:"!);

for (int i = 1; i < N + 1; i++)
    Console.Write($"{Metod(numberA, numberB, i)}  ");

Console.WriteLine();