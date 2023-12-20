//// Написать программу, которая на входе принимает 3х-значное симло и
// возводит 2ю цифру из него в степень, равную третьему числу

// пример:
// 487 -> 8*7 = 2 097 152
// 617 -> 1*7 = 1

Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int a = number / 10;
    int b = a % 10;
    int c = number % 10;
    double result = Math.Pow(b, c);
    Console.WriteLine($"Полученный результат {result}");
}
else
{
    Console.WriteLine("Необходимо ввести трёх-значное число");
}
