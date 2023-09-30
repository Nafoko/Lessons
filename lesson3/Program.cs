﻿// Функции в программировании

// вид 1
using System.Data;
using System.Reflection.Metadata.Ecma335;

void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();


// Вид2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);

// вид 3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид4
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "4"); //Создаем переменную чтобы вызвать метод
Console.WriteLine(res);


// Циклы и не только While
// for(int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i)
// }

// Вид4
string Method5(int count, string text)
{
    string result = string.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res5 = Method5(10, "4"); //Создаем переменную чтобы вызвать метод
Console.WriteLine(res5);

// Цикл в цикле
// for(int i = 0; i < 10; i++)
// {
//     for(int j = 0; j < 10; j++)
//     {
//         Console.WriteLine(i*j);
//     }
//     Console.WriteLine();
// }

for (int i = 2; i <= 9; i++)
{
    for (int j = 2; j <= 9; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}

// Задача.
// Дан текст. В тексте нужно все пробелы заменить черточками.
// маленькие буквы "к" заменить большими "К", а ольшие "С" замегить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винцегероде,"    
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(newText, 'е', 'Ф');
Console.WriteLine(newText);

int[] arr = {1,2,3,4,5,6,7,11, 1,1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition]; 
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);