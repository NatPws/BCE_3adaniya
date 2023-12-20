// вести число (трехзначное) и заставить кодом оставить только две крайние цифры ( 236 -> 26 )

System.Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int a = number % 10;
    int result = number / 100 * 10 + a;

    System.Console.WriteLine($"получаем число: {result}");
}
else
{
    System.Console.WriteLine("Необходиом ввести трех-значное число!");
}
