// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CraateIntRandomArray(int size, int minValue, int maxValue)
{
 int[,] array = new int[size, size];
 for (int i = 0; i < size; i++)
    {
     for (int j = 0; j < size; j++)
        {
         array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
     for (int j = 0; j < array.GetLength(1); j++)
        {
         Console.Write(" " + array[i, j] + "    ");
        }
        Console.WriteLine();
    }
 Console.WriteLine();
}

void FoundAverageOfColumns(int[,] array)
{
 double[] avarage = new double[array.GetLength(1)];
 double sum = 0;
 double size = array.GetLength(1);
 for (int j = 0; j < array.GetLength(1); j++)
   {
     for (int i = 0; i < array.GetLength(0); i++)
      {
       sum = sum + array[i, j];
      }
     avarage[j] = sum / size;
     Console.Write(" " + Math.Round(avarage[j], 2) + " ");
     sum = 0;
   }
}

Console.WriteLine(" Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input row index: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input column index: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] newArray = CraateIntRandomArray(size, min, max);
ShowArray(newArray);
Console.WriteLine("Avarage of columns is: ");
FoundAverageOfColumns(newArray);

