/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

вводим через один Enter (разбиваем через Split())
*/

string AddNumbers()
{
    string stringToReturn = "";
    
    while (true)
    {
        Console.WriteLine("Введите число. Чтобы закончить ввод цифр введите '!'");
        string inputString = Console.ReadLine();
        
        if (inputString.Equals("!")) break;

        stringToReturn += inputString + ",";
    }

    return stringToReturn;
}

int CountPosNumbers (string stringNumbers)
{
    int count = 0;
    string[] array = stringNumbers.Split(",");
    int tempValue = 0;

    
    for (int i = 0; i < array.Length; i++)
    {
        if (int.TryParse(array[i], out tempValue))
        {
            if (tempValue > 0) count ++;
        }
    }

    return count;
}


string numbersString = AddNumbers();
int countPosNumbers = CountPosNumbers(numbersString);
Console.WriteLine(countPosNumbers);