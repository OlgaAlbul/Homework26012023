Console.WriteLine("Введите число A");
int numberA = int.Parse(Console.ReadLine());
int numberB = 1;
while (numberB <= numberA)
{
    if (numberB % 2 == 0)
    {
        Console.WriteLine(numberB);
        numberB = numberB+1;
    }
    else
    {
        numberB = numberB+1;
    }
}