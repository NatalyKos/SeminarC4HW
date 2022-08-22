// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int numberA = ReadInt("Enter number A: ");
int numberB = ReadInt("Enter number B: ");
int count = 1;
int multiply = numberA;
for(count = 1; count < numberB; count++)
{
    multiply = multiply*numberA;
}
if(numberB == 0)
{
    Console.WriteLine(1);
    return;
}
Console.WriteLine(multiply);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}