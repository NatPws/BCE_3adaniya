// Написать программу, оторая на вход принимает 2 числа: А и В
//и возводит А в целую степень В


int ReadInt(string msg)
{
   System.Console.WriteLine(msg);
   return Convert.ToInt32(Console.ReadLine()); 
}

int Pow(int a, int b)
{
    if (b < 1) return 1;
    return a * Pow(a, b - 1);
}




int A = ReadInt("Введите число А: ");
int B = ReadInt("Введите число B: ");
System.Console.WriteLine(Pow(A, B));