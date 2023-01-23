// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
//string[] array= new string[]{"Hello","2","world",":-)"};
string[] array = new string[] { "Hello", "world" };
PrintArray(Program(array));

void PrintArray(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
    }
}

string[] Program(string[] array1)
{
    string[] array2 = new string[1];
    int sizeArray2 = array1.Length;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            sizeArray2++;
            Array.Resize(ref array2, sizeArray2);
            array2[i] = array1[i];
        }
    }
    return array2;
}