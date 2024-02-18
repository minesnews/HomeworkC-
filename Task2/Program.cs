int FunctionAckerman(int m, int n)
{    
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionAckerman(m - 1, 1);
    else if (m > 0 && n > 0) return FunctionAckerman(m-1, FunctionAckerman(m, n-1));
    return FunctionAckerman(m, n);
}

int m = 3;
int n = 5;
int result = FunctionAckerman(m, n);
System.Console.WriteLine(result);

