// Задача 40: 
// Напишите программу, которая принимает на вход три числа 
// и проверяе, может ли существовать треугольник с сторонами такой длины.

// Теотема о неравенстве треугольника:
// каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
bool result = IsExistTriangle(number1, number2, number3);
Console.WriteLine(result ? "Такой треугольник существует" : "Такого треугольника не существует");

bool IsExistTriangle(int num1, int num2, int num3)
{
int sum1 = num1 + num2;
int sum2 = num1 + num3;
int sum3 = num2 + num3;

return sum1 > num3 && sum2 > num2 && sum3 > num1;
}


// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write(arr[i] + ",");
//         else Console.Write(arr[i]);
//     }
//     Console.WriteLine("]");
//}


