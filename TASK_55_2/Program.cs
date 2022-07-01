/*
Задача 55: 
Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

void ReplaceArray(int[,] replaceArray)
{
    int temp;

    for (var i = 0; i < replaceArray.GetLength(0); i++)
    {
        for (var j = i; j < replaceArray.GetLength(1); j++)
        {
            temp = replaceArray[i, j];
            replaceArray[i, j] = replaceArray[j, i];
            replaceArray[j, i] = temp;
        }
    }
}

var array = new int[3, 3];
int[,] result = GenerateArray(array);
PrintArray(result);

System.Console.WriteLine("------------------------------------------------");

if (result.GetLength(0) != result.GetLength(1))
{
    Console.WriteLine($"Невозможно");
}
else
{
    ReplaceArray(result);
    PrintArray(result);
}