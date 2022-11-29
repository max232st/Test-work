// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равно 3 символа.


string[] array = { "hello", "2", "world", ";-)" };
string[] newArray = new string[array.Length];

PrintArray(array);
FillArray(newArray);
Console.WriteLine();
PrintArray(newArray);

void FillArray(string[] newArray)
{
    int count = 0;
    int symbol = 3;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= symbol)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}