Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine()!);
int tmp = numb;

if (numb >= 100)
{
    while (numb >= 1000)
    {
        numb = numb / 10;
    }
    int third = numb % 10;
    System.Console.WriteLine($"{tmp} -> {third}");
}
else System.Console.WriteLine("Третьей цифры нет");