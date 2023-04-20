string text   ="— Я думаю, — сказал князь, улыбаясь, — что,"
              +"ежели бы вас послали вместо нашего милого Винценгероде,"
              +"вы бы взяли приступом согласие прусского короля."
              +"Вы так красноречивы. Вы дадите мне чаю?";


string Replase( string text, char oldValue, char newValue)
{
    string resuit = "";
    int length = text.Length;
    for(int i =0 ; i < length; i++)
    {
        if (text[i] == oldValue) resuit = resuit + $"{newValue}";
        else resuit = resuit + $"{text[i]}";
    }
    return resuit;
}

string newText = Replase(text, 'к', 'К');
Console.WriteLine(newText);
    
