//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)


int[] array = { 1, 8, 6, 12, 48, 34 };

for (int i = 0; i < array.Length / 2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}

Console.WriteLine(String.Join(',', array));


________________________________________________________________________________________________________

//Вторая задача ввести трехзначное число и развернуть его наоборот

// Пример: 456 -> [6, 5 , 4]

long number = 18548165573;
long[] array = new long[11];

for (int i = 0 ; i < array.Length; i++)
{
    array[i] = number % 10;
    number /= 10;
    Console.Write(array[i]);
}

// int работает с массивами размером: [1, 9], но выдает ошибку если 11-значное
// тогда меняем "int" на "long" 

_________________________________________________________________________________________________________________________
// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
{
    if (N < 10)
    {
        Console.WriteLine(N);
    }
    else
    {
        while (N > 0)
        {
            int number = N % 10; 
            N /= 10;
            if (N > 0)
            {
                Console.Write(number + ",");
            }
            else
            {
                Console.WriteLine(number);
            }
        }        
    }
}
