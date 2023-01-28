Console.WriteLine("Введите трехзначное число");
int numberA = int.Parse(Console.ReadLine());
int numberH = 0;
int numberU = 0;
numberH = numberA/100;
numberU = numberA%10;
Console.WriteLine(numberH*10+numberU);
