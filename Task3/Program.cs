int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число.");
        }
    }

    return result;
}

void Sqrt3 (int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{Math.Pow(i,3)}, ");
    }
}

int number = GetNumber("Введите число");

Sqrt3 (number);