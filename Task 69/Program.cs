// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.WriteLine("Возводим введённое вами число А в указанную степень В");
Console.Write("Введите число А=>");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B(>=0)=>");
int power = Convert.ToInt32(Console.ReadLine());

int RaisePower(int n, int m)
{
    if (m < 0 || (n == 0 && m ==0) ) return -1;
    else if (m == 0) return 1;
    else
    {
        n *= RaisePower(n,m-1);
    }
    return n;
}

if (RaisePower(number,power) == -1) Console.WriteLine("Введены недопустимые параметры!");
else Console.WriteLine($"{number} в степени {power} = {RaisePower(number,power)}");
