/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int GetNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}
int m = GetNumber("Введите неотрицательное число m: ");
int n = GetNumber("Введите неотрицательное число n: ");
if (m < 0 || n < 0)
    Console.WriteLine("Необходимо ввести два неотрицательных числа");
else
    Console.WriteLine($"A({m},{n}) = {Ackermann(m, n)}\n");
