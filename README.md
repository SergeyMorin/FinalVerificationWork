# FinalVerificationWork
Final verification work

## Задание

![файл контрольной работы](.\FinalVerificationWork.png)

> Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

>Примеры:

>[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

>[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

>[“Russia”, “Denmark”, “Kazan”] → []

## Текстовое описание решения
1. В качестве вводных данных программа использует массив строк

`imputArray`

2. Для решения задачи нам понадобится сформировать новый массив строк из одного элемента и инициализировать вспомогательную переменную обозначающую количество строк удовлетворяющих условиям и равную нулю.

`string[] outArray = new string[1];`

`int outArray = 0;`

3. Единственному элементу вспомогательного массива присваиваю значение, на случай если в заданном массиве не окажется строк подходящих условию

`outArray[0] = "there are no strings in the array whose length is less than or equal to 3 characters";`

4. Далее запускаю цикл проверки строк первоночального массива на удовлетворение условий задачи

`for (int i = 0; i < imputArray.Length; i++)`

`{`

`if (imputArray[i].Length <= 3)`
    
`{`

    sizeOutArray++;
    Array.Resize(ref outArray, sizeOutArray);
    outArray[sizeOutArray - 1] = imputArray[i];
    
`}`
     
`}`

5. При выполнении условия вспомогательная переменная увеличивается на один.
Далее рамер вспомогательного массива изменяется в зависимости от значения вспомогательной переменной фунцией Resize класса Array. Потом в добавленной строке вспомогательного массива присваеваем значение выполневшие условие из первоначального массива

6. После завершения цикла возвращаем получившийся массив строк

`return outArray;`

## Основной код

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

## Изображение основного кода

![изображение основного кода](.\MainProgram.png)

## Блок-схема алгоритма

![блок-схема алгоритма](.\BlockDiagramOfTheAlgorithm.png)

## GIT Ветки

![GIT Ветки](.\GitBranch.png)

## Вспомогательные материалы
https://learn.microsoft.com/ru-ru/dotnet/api/system.array.resize?view=net-7.0

## Google Disc
https://drive.google.com/drive/folders/1-D8ukysL1O6Feh8XhbgGWQcQf_LGnM0k?usp=sharing