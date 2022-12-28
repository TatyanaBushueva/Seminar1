// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(number) > 99) //модуль
{
    Console.WriteLine(ThirdDigit(Math.Abs(number)));
}
else
{
    Console.WriteLine("третьей цифры нет");
}

int ThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }

    return num % 10;

}