int numberA = new Random().Next(1,100);
Console.WriteLine(numberA);
int numberB = new Random().Next(1,100);
Console.WriteLine(numberB);
int numberC = new Random().Next(1,100);
Console.WriteLine(numberC);
if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.Write("Наибольшее число ");
        Console.WriteLine(numberA);
    }
    else if (numberC > numberB)
    {
        Console.Write("Наибольшее число ");
        Console.WriteLine(numberC);
    }
    else 
    {
        Console.Write("Наибольшее число ");
        Console.WriteLine(numberB);
    }
}
else if (numberB > numberC)
{
    Console.Write("Наибольшее число ");
    Console.WriteLine(numberB);
}
else
{
    Console.Write("Наибольшее число ");
    Console.WriteLine(numberC);
}