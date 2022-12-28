// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if ((Math.Abs(number) > 99) && (Math.Abs(number) <= 999))
{
    Console.WriteLine(SecondDigit(Math.Abs(number)));
}
else
{
    Console.WriteLine("Введенное число не является трехзначным");
}

int SecondDigit(int num)
{
    return num / 10 % 10;
}

