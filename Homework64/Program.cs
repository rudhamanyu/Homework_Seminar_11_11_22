/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

string NumbersFromNTo1(int n, int a)
{
    if (n == 1)
        return a.ToString();
    else
        return NumbersFromNTo1(n - 1, a + 1) + "," + a;
}

int n = GetNumber("Введите число N: ");
int a = 1;
string result = NumbersFromNTo1(n, a);
Console.WriteLine(result);