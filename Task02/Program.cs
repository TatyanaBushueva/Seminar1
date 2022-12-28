/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Write("Ведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if(a > b)
{
   max = a;
   min = b; 
   Console.WriteLine("Первое число больше второго числа");
}
else
{
   max = b;
   min = a; 
   Console.WriteLine("Второе число больше первого числа");
}


