// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateNewArray()
{
    int[,] array = new int[new Random().Next(2, 5), new Random().Next(2, 5)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-3, 10);
        }

    }return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            Console.Write(" ");
        }Console.WriteLine();
    }
}


void FoundElements(int [,]array, int row, int column )
{
   if( row <= array.GetLength(0) && column <= array.GetLength(1))
   Console.WriteLine(array[row,column]);
   else Console.WriteLine("There's no number with such index in the array.");
}

Console.WriteLine("Input row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input column: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] newArray = CreateNewArray();
ShowArray(newArray);
FoundElements(newArray, row, column);