Console.WriteLine("Введите число A");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = int.Parse(Console.ReadLine());
if (numberA ==numberB*numberB)
{
    Console.WriteLine("Первое число является квадратом втрого");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}