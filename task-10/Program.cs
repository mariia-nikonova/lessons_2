Console.Write("Введите трехзначное число: ");
int numb = int.Parse(Console.ReadLine()!);

if (numb >= 100 && numb < 1000)
{
    int second = (numb%100-numb%10)/10;
    System.Console.WriteLine($"Вторая цифра числа {numb} - {second}");
}
else
    System.Console.WriteLine("Число не является трехзначным");