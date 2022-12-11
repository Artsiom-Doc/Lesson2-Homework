// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Digit = N / 10;
int secondDigit = Digit % 10;
Console.WriteLine(secondDigit);