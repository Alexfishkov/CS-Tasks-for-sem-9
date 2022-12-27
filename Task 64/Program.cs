// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Выведем все натуральные числа в промежутке от N до 1");
Console.Write("Введите ваше N=>");
int yourNumber = Convert.ToInt32(Console.ReadLine());

void NumbersDesc(int n)
{
    if (n == 1) Console.Write($"{n}");
    else
    {
        Console.Write($"{n} ");
        NumbersDesc(n - 1);
    }

}

NumbersDesc(yourNumber);
Console.WriteLine();