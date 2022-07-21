// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
Palliandrom(n);
void Palliandrom(int n)
{
       int a; int b; int c; int d;
       a = n/10000%10;
       b = n%10;
       c = n/1000%10;
       d = n/10%10;
       {
       if  ( a == b && c == d )

       Console.WriteLine($" {n} -> Да ");
       else Console.WriteLine($" {n} -> Нет ");
       }
}



