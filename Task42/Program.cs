﻿
// Задача 42:
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// string res = ConvertDecToBin(2);
// Console.WriteLine(res);

// string ConvertDecToBin(int num)
// {
// string result = string.Empty;
// while (num > 0)
// { result = num % 2 + result;
// num = num / 2;
// }
// return result;
// }




Console.Write("Введите число для преобразования в двоичную систему счисления: ");
int number = Convert.ToInt32(Console.ReadLine());

int convertDecimalToBinary = ConvertDecimalToBinary(number);
Console.WriteLine(convertDecimalToBinary);

int ConvertDecimalToBinary(int num)
{
int result = 0;
int multyplyer = 1;

while (num !=0)
{
result = result + num % 2 * multyplyer;
num = num / 2;
multyplyer *=10;
}
return result;
}

