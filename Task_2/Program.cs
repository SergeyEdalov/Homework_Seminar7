// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int EnterData(string message)
{
    Console.WriteLine(message);
    // string value = Console.ReadLine();
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-10,20);
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

int EnterElementPosition(string position)
{
    Console.WriteLine(position);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int ShowElement(int[,] massive, int s, int c)
{
   
    if(s < massive.GetLength(0) && c < massive.GetLength(1)) {Console.WriteLine($"Value: {massive[s,c]}");} 
    else {Console.WriteLine("Enter position of elements less than size massive");}
    return 0;
}


int m = EnterData("Enter number of lines massive");
int n = EnterData("Enter number of columns massive");
int[,] array = new int[m,n];

FillArray(array);
Console.WriteLine();
PrintArray(array);

int s = EnterElementPosition("Enter position of string in massive");
int c = EnterElementPosition("Enter position of column in massive");

ShowElement(array, s, c);

