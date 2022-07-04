// 

string Text = "кк СС Кс";

// string s = "qwerty"
//             012345
//  s[3]  --->  r

string Replace(string text, char oldValue, char newValue)    // Принимаем текст и меняем один символ на другой!
{
    string result = string.Empty; // Пустая строка
    
    int lenght = text.Length; // Кол-во символов в строке
    for(int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result+ $"{text[i]}";
    }
    return result;
}

string newText = Replace(Text, ' ', '-');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
