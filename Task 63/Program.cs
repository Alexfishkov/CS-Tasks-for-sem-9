// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.WriteLine("Выведем все натуральные числа в промежутке от 1 до N");
Console.Write("Введите ваше N=>");
int yourNumber = Convert.ToInt32(Console.ReadLine());

int Numbers (int n)
{
    if (n < 0) return -1;
    if (n == 0 || n==1) return 1;
    Console.Write($"{Numbers(n-1)} ");
    return n;
}

if (Numbers(yourNumber) == -1) Console.WriteLine("Ошибка при вводе N!");
else Console.WriteLine(Numbers(yourNumber));