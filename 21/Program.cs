//написать программу, на вхол принимает целые числа 
//и перепроверяет, являеься ли второе число квадратом первого
// a = 25, b = 5  => да
// a = 2, b = 10 => нет
// a = 9, b = -3  => да
// a = -3, b = 9  => нет

Console.WriteLine("Ввкдите число а");
string strA = Console.ReadLine();
int a = Convert.ToInt32(strA);
//int a = 36; 

Console.WriteLine("Ввкдите число b");
string strB = Console.ReadLine();
int b = Convert.ToInt32(strB);
//int b = 6;

int c = b * b;
if(c == a)
{Console.WriteLine("Да");
} else {  
Console.WriteLine("Нет");
}