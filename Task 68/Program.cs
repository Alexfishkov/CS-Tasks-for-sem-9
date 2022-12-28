// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();
Console.WriteLine("Вычисляем значения функции Аккермана по введённым вами неотрицательным целым числам M и N");
Console.Write("Введите значение M(>=0)=>");
long numberM = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите число N(>=0)=>");
long numberN = Convert.ToInt64(Console.ReadLine());

long AckerFunction(long m, long n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckerFunction(m - 1, 1);
    else if (m > 0 && n > 0) return AckerFunction(m - 1, AckerFunction(m, n - 1));
    else return -1;
}

if (AckerFunction(numberM,numberN) == -1) Console.WriteLine("Введены недопустимые параметры");
else
Console.WriteLine($"Значение функции Аккермана для этих параметров: {AckerFunction(numberM,numberN)}");
