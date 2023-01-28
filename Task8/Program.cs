int numberA = new Random().Next(10,99);
Console.WriteLine(numberA);
int numberD = 0;
int numberU = 0;
numberD = numberA/10;
numberU = numberA%10;
if (numberD>numberU)
{
    Console.Write("Наибольшая цифра числа ");
    Console.WriteLine(numberD);
}
else
{
    Console.Write("Наибольшая цифра числа ");
    Console.WriteLine(numberU);
}