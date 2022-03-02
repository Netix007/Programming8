// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] GetArr(int k, int m)
{
    Random randomizer = new Random();
    int[,] arr = new int[k,m];
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i,j] = randomizer.Next(-10,10);
            Console.Write($"{arr[i,j]}        ");
        }
        Console.WriteLine();
    }
    return arr;
} 

int MinSumStr(int[,] arr)
{
    int minSum = 0;
    int sum = 0;
    int str = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            str = i;
        }
        sum = 0;
    }
    return str;
}

int[,] arr = GetArr(4,5);
Console.WriteLine();
int strNumber = MinSumStr(arr);
Console.WriteLine($"Наименьшая сумма элементов в {strNumber+1} строке");
