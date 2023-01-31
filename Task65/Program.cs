// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

NaturalNumbersRange(firstNumber, secondNumber);

void NaturalNumbersRange(int firstNum, int secondNum)
{
    if (firstNum == secondNum) Console.Write($"{firstNum} ");
    else if (firstNum < secondNum)
    {// if (num == 0) return;
     //NaturalNumbers(num - 1);
        Console.Write($"{firstNum} ");
        NaturalNumbersRange(firstNum + 1, secondNum);

    }
    else if (firstNum > secondNum)
    {
        Console.Write($"{firstNum} ");
        NaturalNumbersRange(firstNum - 1, secondNum);
    }
}
