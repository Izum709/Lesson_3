// Методы While VS For

string MethodWhile(int count, string c)
{
    
    string result = "";
    for (int i = 0; i < count; i++)
    {
        result = result + c;
        
    }
    return result;
}

string res = MethodWhile(10, " text " );
Console.WriteLine(res);
