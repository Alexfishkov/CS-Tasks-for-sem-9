// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Посчитаем сумму натуральных чисел, расположенных в промежутке от указанных вами M до N");

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
    if (yourNumber1 < 0 || yourNumber2 < 0) Console.WriteLine("Ошибка при вводе, выполните корректный ввод!");

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

int SumOfElements(int m, int n)
{
    if (n == m) return m;
    if (n > m) return n + SumOfElements(m, n - 1);
    else return -1;

}

Console.WriteLine($"Сумма элементов в этом диапазоне составляет: {SumOfElements(numMin, numMax)}");

