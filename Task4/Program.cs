// 63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

int[,,] GetArr(int k, int m, int n)
{
    Random randomizer = new Random();
    int[,,] arr = new int[k,m,n];
    bool isErr = true;
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int l = 0; l < n; l++)
            {
                while (isErr)
                {
                    arr[i,j,l] = randomizer.Next(10,100);
                    isErr = IsError(arr, i, j, l);
                }
                isErr = true;
            }
        }
    }
    return arr;
}

bool IsError(int[,,] arr, int k, int m, int n)
{
    bool theSame = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int l = 0; l < arr.GetLength(2); l++)
            {
                if (arr[i,j,l] == arr[k,m,n])
                {
                    if (i != k && j != m && l != n)
                    {
                        theSame = true;
                        return theSame;
                    }
                    else
                    {
                        theSame = false;
                    }
                    break;
                }
            }
        }
    }
    return theSame;
}

void PrintArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine($"Plane {i}");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int l = 0; l < arr.GetLength(2); l++)
            {
                Console.Write(String.Format("{0,15}", $"({i},{j},{l}) = {arr[i,j,l]} "));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int[,,] arr = GetArr(2,5,5);
PrintArr(arr);
