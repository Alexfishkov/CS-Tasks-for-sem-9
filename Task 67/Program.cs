// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write("Введите число =>");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int FigureSum(int sum)
{
    if (sum == 0) return sum;
    else
    {
        sum = sum % 10 + FigureSum(sum / 10);
    }
    return sum;
}

Console.WriteLine($"Сумма его цифр составляет: {FigureSum(num)}");
