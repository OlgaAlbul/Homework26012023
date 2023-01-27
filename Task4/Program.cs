Console.WriteLine("Введите число A");
int numberA = int.Parse(Console.ReadLine());
if (numberA % 2 ==0)
{
    Console.Write(numberA);
    Console.WriteLine(" четное число");
}
else
{
    Console.Write(numberA);
    Console.WriteLine(" нечетное число");
}