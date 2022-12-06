Console.Clear();
int DataEntry(string str)

{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindSum(int num)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int number = DataEntry("Введите число A: ");
int result = FindSum(number);
Console.WriteLine("Сумма всех чисел до А равна " + result);