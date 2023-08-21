
//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] EnterMassive(string[] massive)
{
    Console.WriteLine("Enter values");
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = Console.ReadLine()!;
    }
    return massive;
}

void PrintArray(string[] arr)
{
    Console.Write($"[{String.Join(' ', arr)}]");
    Console.WriteLine();
}

Console.WriteLine("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] mass = new string[7];

mass = EnterMassive(mass);
Console.WriteLine("Start massive");
PrintArray(mass);

int shortCount = CountShortStrings(mass);

NewMassive(mass, shortCount);

int CountShortStrings(string[] massive)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

void NewMassive(string[] array, int numberOfShortStrings)
{
    string[] NewMass = new string[numberOfShortStrings];
    int lengthCount = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length <= 3 && lengthCount <= numberOfShortStrings)
        {
            NewMass[lengthCount] = array[i];
            lengthCount++;
        }
        if(lengthCount > numberOfShortStrings) break;
    }
Console.WriteLine("New massive");
PrintArray(NewMass);
}




