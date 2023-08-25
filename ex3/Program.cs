// Дан текст. заменить пробелы черточками, 
//маленькие к большими К
// большие С на маленькие с

string text = "-Я думаю, сказал князь, - что"
            + "ежели бы вас послали вместо нашего милого Винценгероде"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
//text[i]            
string Replase(string text, char oldValue, char newValue)
{
    int length = text.Length;
    string result = String.Empty;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, ' ', '|');
System.Console.WriteLine(newText );
System.Console.WriteLine( );
newText = Replase(text, 'к', 'К');
System.Console.WriteLine(newText );
System.Console.WriteLine( );
newText = Replase(text, 'с', 'С');
System.Console.WriteLine(newText );
System.Console.WriteLine( );