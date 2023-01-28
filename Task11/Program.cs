Console.WriteLine("Введите число");
int numberA = int.Parse(Console.ReadLine());
if(numberA > 99)
{
    Console.WriteLine((numberA / 100) % 10);
}
else
{
    Console.WriteLine("Отсутствует третья цифра");
}