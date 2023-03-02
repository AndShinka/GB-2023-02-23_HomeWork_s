// 2. Найти сумму элементов от M до N, N и M заданы
// 02_task_HW_2023-02-23

int SumNaturalNumber(int m, int n)
{
    if (n == m) return n;
    return m + SumNaturalNumber(m + 1, n);
}

int numberM = 1;
int numberN = 5;

Console.Clear();
Console.WriteLine($"2. Найти сумму элементов от M до N, N и M заданы, M = {numberM}, N = {numberN}" !);
Console.WriteLine();
Console.WriteLine($"Cумма элементов от M = {numberM} до  N = {numberN} равна {SumNaturalNumber(numberM, numberN)}" !);

Console.WriteLine();