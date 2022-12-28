// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Выведем все натуральные числа в промежутке от N до 1");
int yourNumber = 0;
do
{
    Console.Write("Введите ваше N(>=1)=>");
    yourNumber = Convert.ToInt32(Console.ReadLine());
    if (yourNumber <= 0) Console.WriteLine("Ошибка при вводе N. Введите N>0 ");

} while (yourNumber <= 0);

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