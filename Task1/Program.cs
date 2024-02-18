void OutputOfNumbers(int m, int n)
{
    int result = m;
    if(result == n)
    {
        System.Console.Write(result);
        return;
    }
    System.Console.Write($"{result} ");
    OutputOfNumbers(m+1, n);
}

int m = 10;
int n = 20;

OutputOfNumbers(m, n);
