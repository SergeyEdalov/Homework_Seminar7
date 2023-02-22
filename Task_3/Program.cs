// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int EnterData(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 20);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double FindAverage(int[,] matr)
{
    double aver = 0;
    double sum = 0; 
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }
        aver = Math.Round(sum / matr.GetLength(1), 2);

        Console.Write($"{aver} ");
        sum = 0;        
    }
    return aver;
}

int m = EnterData("Enter string massive");
int n = EnterData("Enter column massive");
int[,] array = new int[m, n];

FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();

Console.Write("Average each column massive is ");
FindAverage(array);