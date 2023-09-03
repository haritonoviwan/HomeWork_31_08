// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "");

int sum = SumOfNaturalNumbers(m, n);
Console.WriteLine(sum);

int SumOfNaturalNumbers(int start, int stop)
{
    if (start == stop) return start;
    return (start + SumOfNaturalNumbers(start + 1, stop));
}