// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Clear();
int DataEntry(string str)

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Find(int num)
{
    int count = 0;

    for (count = 0; num > 0; count++)
    {
        num = num/10;                  
    }
    return count;
}

int number = DataEntry("Введите число: ");
int result = Find(number);
Console.WriteLine("Количество цифр в числе: " + result);