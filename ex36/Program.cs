// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = CreateArray(6);
PrintArray(array);
System.Console.WriteLine($"сумма нечетных элементов в массиве = {CalculationSum(array)}");

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 20);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length-1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.WriteLine();
}

int CalculationSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        sum += arr[i];
    }
    return sum;
}