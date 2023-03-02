// 4. Написать программу вычисления функции Аккермана
// 04_task_HW_2023-02-23
// Для примера : при m = 3, n = 5 -> A(m,n) = 253

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int numberM = 3;
int numberN = 5;

Console.Clear();
Console.WriteLine($"4. Написать программу вычисления функции Аккермана, N и M заданы, M = {numberM}, N = {numberN}" !);
Console.WriteLine();
Console.WriteLine($"Значение функции Аккермана при M = {numberM} и  N = {numberN} равно {Ack(numberM, numberN)}" !);
Console.WriteLine();

