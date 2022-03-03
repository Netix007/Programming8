// Задача 65: Спирально заполнить двумерный массив
 
int[,] GetArr(int[,] arr)
{
    int number = 1;
    int count = 0;
    int maxNumber = arr.GetLength(0) * arr.GetLength(1);
    while (number <= maxNumber)
    {
        for (int i = count; i < arr.GetLength(1) - count; i++)
        {
            arr[count,i] = number;
            number++;
        }
        for (int j = count+1; j < arr.GetLength(0)-count; j++)
        {
            arr[j,arr.GetLength(1)-count-1] = number;
            number++;
        }
        for (int i = arr.GetLength(1) - count - 2; i >= count; i--)
        {
            arr[arr.GetLength(0)-count-1,i] = number;
            number++;
        }
        for (int j = arr.GetLength(0) - count - 2; j >= count+1 ; j--)
        {
            arr[j,count] = number;
            number++;
        }
        count++;
    }
    return arr;
}

 
void PrintArr(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
Console.Write(String.Format("{0,5}", arr[i,j]));
}
Console.WriteLine();
}
}

int[,] arr = new int[6,6];
arr = GetArr(arr);
PrintArr(arr);
 
Console.WriteLine("Hello, World!");
