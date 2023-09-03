// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.Clear();
Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine() ?? "");
string numbers = NaturalNumbers(num, 1);
Console.WriteLine(numbers);

string NaturalNumbers(int n, int end)
{
    if (n == end) return end.ToString();
    return n + " " + NaturalNumbers(n - 1, end);
}
