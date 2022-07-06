int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            if (result > 9999 && result <= 100000)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не пятизначное число");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число.");
        }
    }

    return result;
}
int number = GetNumber("Введите число");
string palindrom = Convert.ToString(number);

if (palindrom[0]==palindrom[4] && palindrom[1]==palindrom[3])
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");