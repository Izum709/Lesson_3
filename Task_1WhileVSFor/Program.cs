// Методы While VS For

string MethodWhile(int count, string c)
{
    int i = 0;
    string result = "";
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = MethodWhile(10, " text " );
Console.WriteLine(res);
