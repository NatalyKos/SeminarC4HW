// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]

int size = ReadInt("Enter the size of the array: ");
int[] numbers = new int[size];

FillArrayRandomNumbres(numbers);
PrintArray(numbers);


void FillArrayRandomNumbres(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
