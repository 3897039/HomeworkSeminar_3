// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]  6, 1, 33 -> [6, 1, 33]

int Prompt(string msg)
{
    Console.Write(msg);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int [] MyArray(int Length, int numberMin, int numberMax)
{
    int[] array = new int[Length];
    Random random = new Random();
    for(int i = 0; i < Length; i++)
    {
        array[i] = random.Next(numberMin, numberMax + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write(" [");
    for(int i = 0; i < array.Length -1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length -1]}");
    Console.Write("]");
}
int length = Prompt("Введите длину массива: ");
int min = Prompt("Введите минимальное число массива: ");
int max = Prompt("Введите максимальное число массива: ");
int [] array = MyArray(length, min, max);
PrintArray(array);


