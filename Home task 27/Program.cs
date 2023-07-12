/*
Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum (int number)
{
    int advance = 0;
    int result = 0;
    int counter = Convert.ToString(number).Length; 

    for (int i = 0; i < counter; i++)
    {
        advance = number - number % 10;
        result = result + (number - advance);
        number = number / 10;  
    }
    return result;
}

int sumNumbers = Sum(number);

bool Check(int sumNumbers)
{
    if (sumNumbers < 0)
    {
        Console.Write($"Введено отрицательное число");
        return false; 
    }
    return true;
}

if (Check(sumNumbers))
{
    Console.WriteLine($"Сумма всех цифр числа {number} равна {sumNumbers}");
}


