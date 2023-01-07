Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int count = Convert.ToInt32(Console.ReadLine());
NaturalToLow(number, count);


void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count  + 1);
        Console.Write (count + " ");
    }
};
