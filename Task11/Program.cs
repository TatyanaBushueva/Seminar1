/*  11. Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98  */

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100-999 => {number}");

int deleteSecondDigit = DeleteSecondDigit(number);
Console.WriteLine($"Искомое число => {deleteSecondDigit}");

int DeleteSecondDigit(int num)  //num = number
{
    int firstDigit = num / 100;
    int thirDigit = num % 10;
    int result = firstDigit * 10 + thirDigit;
    return result;
}

