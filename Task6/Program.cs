Console.WriteLine("Введите число A");
int numberA = int.Parse(Console.ReadLine());
int numberB = 0;
numberB = numberA/10;
numberA = numberA-numberB*10;
Console.WriteLine(numberA);