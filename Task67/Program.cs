// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



// int Factorial(int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SunDigit(number));
int SunDigit(int n)
{
 // 1! = 1
 // 0! = 1
 if(n == 0) return 0;
 return n % 10 + SunDigit(n / 10);
}
