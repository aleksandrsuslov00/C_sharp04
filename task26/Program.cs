/*
Напишите программу, которая принимает на вход число
и выдает количество цифр в числе

456 -> 3;
68 -> 2;
89126 -> 5;
*/

int AmountOfDigits(int number)
{
    int  amount = 0;
    while (number > 0)
    {
        number /= 10; //number = number / 10;
        amount++; // amount = amount + 1
    }
    return amount;
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {num} равно {AmountOfDigits(num)}");
