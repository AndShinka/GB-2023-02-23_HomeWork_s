// ### 1. Показать натуральные числа от M до N, N и M заданы
// 01_task_HW_2023-02-23

void PrintNaturalNumber(int m, int n)
{
    if (n < m) return;
    PrintNaturalNumber(m, n - 1);
    Console.Write(n + " ");
}

int numberM = 11;
int numberN = 30;

Console.Clear();
Console.WriteLine($"1. Показать натуральные числа от M до N, N и M заданы, M = {numberM}, N = {numberN}" !);
PrintNaturalNumber(numberM, numberN);
Console.WriteLine();
