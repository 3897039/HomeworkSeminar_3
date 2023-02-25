// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)  2, 4 -> 16

int Prompt(string msg)
{
    Console.Write(msg);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int NaturalDegree( int numberA, int numberB)
{
    int naturaldegree = 1;
    for(int i =0; i < numberB; i++)
    {
        naturaldegree *= numberA;
    }
    return naturaldegree;
}

bool ValidateNumberB(int numberB)
{
    if(numberB < 0)
    {
        Console.WriteLine("Степень не может быть меньше нуля");
        return false;
    }
    return true;
}

int numberA = Prompt("Введите число А -> ");
int numberB = Prompt ("Введите число В -> ");

if (ValidateNumberB(numberB))
{
    Console.WriteLine($"Число {numberA} в степени {numberB} равно {NaturalDegree(numberA, numberB)}");
}
