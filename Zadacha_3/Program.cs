//  Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.Clear();
int DataEntry(string str)

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindSum(int num)
{
    int sum = 1;

    for (int i = 1; i <= num; i++)
    {
        sum = sum * i;
    }
    return sum;
}

int number = DataEntry("Введите число N: ");
int result = FindSum(number);
Console.WriteLine($"{number} -> " + result);