// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Clear();
Console.Write("Введите неотрицательное число m: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите неотрицательное число n: ");
int n = int.Parse(Console.ReadLine() ?? "");

int result = AckermannFunction(m, n);
Console.WriteLine(result);

int AckermannFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numN == 0) return AckermannFunction(numM - 1, 1);
    else return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
}
