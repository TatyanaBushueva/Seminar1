// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number >= 1) && (number <= 7))
{
    Console.WriteLine(IsWeekend(number) ? "Да" : "Нет");
}
else
{
    Console.WriteLine("Введена неверная цифра");
}

bool IsWeekend(int num)
{
    return ((num == 6) || (num == 7));
}
