// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива. 

//Пример: массив [2.2 0.4 9.11 7.2 78.98] => 78.58
//        массив [1.22 4.5 3.33] => 3.28

double[] arr = { 8.6, 1.2, 4.83, 99.29, 30.4 };

Console.WriteLine("Minimum number is " + arr.Min());
Console.WriteLine("Maximum number is " + arr.Max());
double result = arr.Max() - arr.Min();
Console.WriteLine("Разница = " + result);
