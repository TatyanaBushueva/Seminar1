/* 12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */


/* Console.WriteLine("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//int res = MultipleDigit(firstNumber, secondNumber);

Console.Write($"{firstNumber}, {secondNumber} => ");
Console.WriteLine(MultipleDigit(firstNumber, secondNumber));

string MultipleDigit(int firstNum, int secondNum)  //num = number
{
    if(firstNum < secondNum)
    {
        return "первое меньше второго - проверить кратность невозможно";
    }
    else
    {
    return firstNum % secondNum == 0 ? "кратно" : $"не кратно, остаток {firstNumber}, остаток {firstNum % secondNum}";
    }
}  */


Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int res = Multiplicity(numberOne, numberTwo);
Console.WriteLine(res == 0 ? "Кратно" : $"не кратно, остаток от деления {res}");
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine($"Не кратно, остаток {div}");
// }

int Multiplicity(int numOne, int numTwo)
{
    return numOne % numTwo;
}
