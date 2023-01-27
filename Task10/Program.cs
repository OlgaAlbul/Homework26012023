int numberA = new Random().Next(1,100);
Console.WriteLine(numberA);
Console.WriteLine("Введите число ");
int numberB = int.Parse(Console.ReadLine());
int numberS = numberA % numberB;
if (numberS == 0)
{
    Console.Write("Число ");
    Console.Write(numberA);
    Console.Write(" кратно числу ");
    Console.Write(numberB);
}
else
{
    Console.WriteLine(numberS);
}