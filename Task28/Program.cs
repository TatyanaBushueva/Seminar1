// Задача 28: 
// Напишите программу, которая
// 1. принимает на вход число N и 
// 2.выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
//int number1 = int.Parse(Console.ReadLine());
//if number <= 0


int fakt = Fakt(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {fakt}");

int Fakt(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    { 
        checked
        {
        //sum = sum + i;
        result *=i;
        }
    }
    return result;
}
