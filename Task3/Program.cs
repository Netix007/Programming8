// 61. Найти произведение двух матриц

int[,] GetArr(int k, int m)
{
    Random randomizer = new Random();
    int[,] arr = new int[k,m];
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i,j] = randomizer.Next(-10,10);
        }
    }
    return arr;
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}        ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiplicationArr(int[,] firstArr, int[,] secondArr)
{
    int[,] resultArr = new int[firstArr.GetLength(0),secondArr.GetLength(1)];
    int multipl = 0;
    for (int i = 0; i < secondArr.GetLength(1); i++)
    {
        for (int j = 0; j < firstArr.GetLength(0); j++)
        {
            for (int k = 0; k < firstArr.GetLength(1); k++)
            {
                multipl += firstArr[j,k]*secondArr[k,i];
            }
        resultArr[j,i] = multipl;
        multipl = 0;
        }
    }
    return resultArr;
}

Console.WriteLine("Первая матрица");
int[,] firstArr = GetArr(4,5);
PrintArr(firstArr);
Console.WriteLine("Вторая матрица");
int[,] secondArr = GetArr(5,2);
PrintArr(secondArr);
if (firstArr.GetLength(1) == secondArr.GetLength(0))
{
    Console.WriteLine("Произведение двух матриц");
    int[,] resultArr = MultiplicationArr(firstArr, secondArr);
    PrintArr(resultArr);
}
else
{
    Console.WriteLine("Невозможно умножить матрицы");
}

