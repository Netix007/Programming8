// Задача 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерной массива.

int[,] GetArray(int m, int n)
{
    Random rand = new Random();
    int[,] arr = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = rand.Next(-10,10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] arr = GetArray(5,5);
PrintArray(arr);
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int max = arr[i,j];
        for (int k = j+1; k < arr.GetLength(1); k++)
        {
            if (max < arr[i,k])
            {
                max = arr[i,k];
                arr[i,k] = arr[i,j]; 
            }   arr[i,j] = max;
        }
    } 
}
PrintArray(arr);
