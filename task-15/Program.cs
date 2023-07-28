Console.Write("Введите число от 1 до 7: ");
int numb = int.Parse(Console.ReadLine()!);

if ((numb == 7) || (numb == 6)) Console.WriteLine($"{numb} - да");
else Console.WriteLine($"{numb} - нет");