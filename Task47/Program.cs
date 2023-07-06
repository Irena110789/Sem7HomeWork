// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray(int m, int n, int minValue, int maxValue)
{
 double[,] array = new double[m,n];
 for (int i = 0; i < m ; i++)
    {
     for (int j = 0; j < n ; j++)
        {
         array[i,j] = new Random().Next(minValue,maxValue) + Math.Round(new Random().NextDouble(), 1);
        }
    }return array;
}

void ShowArray(double[,] array)
{
for (int i = 0; i <array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
     Console.Write(" " + array[i,j] + " ");
    }
 Console.WriteLine();Console.WriteLine();
} 
Console.WriteLine();

}
Console.WriteLine("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
double[,] newArray = CreateArray(m,n,minValue,maxValue);
ShowArray(newArray);