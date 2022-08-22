// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int number = ReadInt("Enter a number: ");
int sum = number % 10;
int count = 0;
int last = 0;
for(count = 0; number > 0; count++)
{
    number /= 10;
    last = number % 10;
    sum = sum + last;
}
Console.WriteLine(sum);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
