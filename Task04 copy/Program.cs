﻿/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b && a > c) Console.WriteLine($"Максимальное число: {a}");
if(b > a && b > c) Console.WriteLine($"Максимальное число: {b}");
if(c > b && c > a) Console.WriteLine($"Максимальное число: {c}");

