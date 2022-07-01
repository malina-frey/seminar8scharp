/*
Задача 53: 
Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
*/

int[,] GenerateArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);

        }
    }
    return array;
}

void PrintArray(int[,] printToArray)
{
    for (var i = 0; i < printToArray.GetLength(0); i++)
    {
        for (var j = 0; j < printToArray.GetLength(1); j++)
        {
            Console.Write($"   {printToArray[i, j]}   ");
        }
        Console.WriteLine();
    }
}

int[,] ReplaceIndex(int[,] replaceArray)
{
    int temp = 0;
    for (var i = 0; i < replaceArray.GetLength(1); i++)
    {
        temp = replaceArray[0, i];
        replaceArray[0, i] = replaceArray[replaceArray.GetLength(0) - 1, i];
        replaceArray[replaceArray.GetLength(0) - 1, i] = temp;
    }
    return replaceArray;
}

var array = new int[5, 6];
int[,] result = GenerateArray(array);


PrintArray(result);
System.Console.WriteLine("------------------------------------------------");

int[,] replaceArray = ReplaceIndex(result);
PrintArray(replaceArray);
