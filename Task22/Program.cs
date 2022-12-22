// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


System.Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
if (number > 0)

{
    TableSquare(number);
}
else System.Console.WriteLine("Не натуральное число");

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,5} {Math.Pow(count, 2),5}");
        count++;
    }
}
