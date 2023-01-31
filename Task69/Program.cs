﻿
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите натуральное число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int numberDegree = NumberDegree(numberA, numberB);
Console.WriteLine($"Возведение числа А в степень B = {numberDegree}");

int NumberDegree(int numA, int numB)
{
    if (numB == 0) return 1;
    else return numA * NumberDegree(numA, numB - 1);
}



