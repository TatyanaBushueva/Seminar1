// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
1. Напишите программу, которая на вход принимает два
числа и проверяет, является ли первое число квадратом
второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет */


Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secontNumber = Convert.ToInt32(Console.ReadLine());
int  square= secontNumber * secontNumber;
if(square == firstNumber)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
     Console.WriteLine("Первое число не является квадратом второго");
}


