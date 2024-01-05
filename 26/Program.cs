/* // Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.

Пример
N=5 => 1 2 3 4 5 */


void Number(int n)
{
    if (n < 1) return;
    Number(n - 1);
    System.Console.Write(n + " ");
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Number(N);

// 