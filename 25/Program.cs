/*  Напишите программу, которая будет принимать на вход число и возвращать сумму всех его цифр.
 Использовать рекурсию.
Пример
123 => 6
63 => 9 */

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigitsNumber(int number)
{
    if (number == 0) return 0;
    return number % 10 + SumDigitsNumber(number/10);
}



int value = ReadInt("Введите число: ");
System.Console.WriteLine(SumDigitsNumber(value));
