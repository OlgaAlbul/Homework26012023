Console.WriteLine("Введите трехзначное число");
int numberA = int.Parse(Console.ReadLine());
int numberH = 0;
int numberD = 0;
int numberU = 0;
numberH = numberA/100;
numberD = numberA/10;
numberU = numberA-numberD*10;
Console.WriteLine(numberH*10+numberU);
