// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] arrayEx1 = new string[] { "Hello", "world", "2", ":-)" }; //Пример массива 1
string[] arrayEx2 = new string[] { "1234", "1567", "-2", "computer since" }; //Пример массива 2
string[] arrayEx3 = new string[] { "Russia", "Denmark", "Kazan" }; //Пример массива 3

Console.Write("["); //Пример 1 Вывод результата в консоль
PrintArray(arrayEx1);
Console.Write(" ] → ");
Console.Write("[");
PrintArray(Program(arrayEx1));
Console.WriteLine(" ]");

Console.Write("["); //Пример 2 Вывод результата в консоль
PrintArray(arrayEx2);
Console.Write(" ] → ");
Console.Write("[");
PrintArray(Program(arrayEx2));
Console.WriteLine(" ]");

Console.Write("["); //Пример 3 Вывод результата в консоль
PrintArray(arrayEx3);
Console.Write(" ] → ");
Console.Write("[");
PrintArray(Program(arrayEx3));
Console.WriteLine(" ]");

void PrintArray(string[] array) // вывод массива в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" {" + array[i] + "}");
    }
}

// Программа, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам.
string[] Program(string[] imputArray)
{
    string[] outArray = new string[1];
    outArray[0] = "there are no strings in the array whose length is less than or equal to 3 characters";
    int sizeOutArray = 0;
    for (int i = 0; i < imputArray.Length; i++)
    {
        if (imputArray[i].Length <= 3)
        {
            sizeOutArray++;
            Array.Resize(ref outArray, sizeOutArray);
            outArray[sizeOutArray - 1] = imputArray[i];
        }
    }
    return outArray;
}