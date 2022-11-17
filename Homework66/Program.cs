/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int GetNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int NumbersFromMToN(int m, int n)
{
    if (n == m)
        return m;
    else
        return NumbersFromMToN(m, n - 1) + n;
}
int m = GetNumber("Введите число M: ");
int n = GetNumber("Введите число N: ");
int result = NumbersFromMToN(m, n);
Console.WriteLine(result);