// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
// ["4G" ,"0422", "042B", ":-)" , "041A", "041E", "0417", "041B", "0418", "043D", "0430" , "14"] → [ {4G} {:-)} {14} ]

string[] arrayEx1 = new string[] { "Hello", "world", "2", ":-)" }; //Пример массива 1
string[] arrayEx2 = new string[] { "1234", "1567", "-2", "computer since" }; //Пример массива 2
string[] arrayEx3 = new string[] { "Russia", "Denmark", "Kazan" }; //Пример массива 3
string[] arrayEx4 = new string[] { "4G" ,"0422", "042B", ":-)" , "041A", "041E", "0417", "041B", "0418", "043D", "0430" , "14"}; //Пример массива 4

PrintFrameAndArray(arrayEx1); //Пример 1 Вывод результата в консоль
PrintFrameAndArray(arrayEx2); //Пример 2 Вывод результата в консоль
PrintFrameAndArray(arrayEx3); //Пример 3 Вывод результата в консоль
PrintFrameAndArray(arrayEx4); //Пример 4 Вывод результата в консоль

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

void PrintFrameAndArray(string[] arr)
{
    Console.Write("[");
    PrintArray(arr);
    Console.Write(" ] → ");
    Console.Write("[");
    PrintArray(Program(arr));
    Console.WriteLine(" ]");
}