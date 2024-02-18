void PrintReverseArray(int[] array, int length)
{
    
    if(length == 0)
    {
        return;
    }
    System.Console.Write($"{array[length - 1]} ");
    PrintReverseArray(array, length - 1);
}

int[] array = { 1, 2, 3, 4, 5, -1, 10 };
int length = array.Length;
PrintReverseArray(array, length);