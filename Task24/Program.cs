// Задача 24: Напишите программу, которая
// 1.принимает на вход число (А) 
// 2. и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
//int number1 = int.Parse(Console.ReadLine());
int sunNumber = SunNumber(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sunNumber}");

int SunNumber(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        //sum = sum + i;
        sum +=i;
    }
    return sum;
}


