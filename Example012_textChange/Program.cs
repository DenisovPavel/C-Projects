

string text = "- Я думаю, – сказал князь, улыбаясь, – что, "
 + " ежели бы вас послали вместо нашего милого Винценгероде,"
 + " вы бы взяли приступом согласие прусского короля."
 + " Вы так красноречивы. Вы дадите мне чаю? ";

string Replace(string text, char oldValue, char newValue)
{
    int lenght = text.Length;
    string result = String.Empty;

    for (int i = 0; i < lenght; i++)
    {

        if (text[i] == oldValue)
            result = result + $"{newValue}";

        else result = result + $"{text[i]}";

    }

    return result;
}
string newtext = Replace(text,' ','|');
Console.WriteLine(newtext);
Console.WriteLine();
string newtext1 = Replace(newtext,'к','К');
Console.WriteLine(newtext1);
Console.WriteLine();
string newtext2 = Replace(newtext1,'|','_');
Console.WriteLine(newtext2);