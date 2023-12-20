// Написать программу, которая складывает крайние цифры в числк
// 456 => 10;
// 582 => 7;
// 353 => 6;


Console.WriteLine("Введите трех-значное число: ");
string A = Console.ReadLine ();

int E = Convert.ToInt32(A);
int B = E / 100;
int C = E % 10;
int D = B + C;

Console.WriteLine(D);