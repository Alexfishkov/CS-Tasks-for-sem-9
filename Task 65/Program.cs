// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();
Console.WriteLine("Выведем на экран все натуральные числа в промежутке от указанных вами M до N");

int yourNumber1 = 0;
int yourNumber2 = 0;
int numMin = 0;
int numMax = 0;

do
{
    Console.Write("Введите ваше M(>=0)=>");
    yourNumber1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите ваше N(>=0)=>");
    yourNumber2 = Convert.ToInt32(Console.ReadLine());
    if (yourNumber1 < 0 || yourNumber2 <0) Console.WriteLine("Ошибка при вводе, выполните корректный ввод!");

} while (yourNumber1 < 0 || yourNumber2 < 0);

if (yourNumber1 > yourNumber2) 
{
    numMin = yourNumber2;
    numMax = yourNumber1;
}

else
{
    numMin = yourNumber1;
    numMax = yourNumber2;
}

int NumbersInsideRange (int m, int n)
{
    if (n == m) return m;
    Console.Write($"{NumbersInsideRange(m,n-1)} ");
    return n;
}

Console.WriteLine(NumbersInsideRange(numMin,numMax));