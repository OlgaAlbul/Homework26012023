Console.WriteLine("Введите трехзначное число ");
int numberA = int.Parse(Console.ReadLine());
int numberH = 0;
int numberD = 0;
numberH = numberA/100;
numberA = numberA - numberH*100;
numberD = numberA/10;
Console.WriteLine(numberD);
