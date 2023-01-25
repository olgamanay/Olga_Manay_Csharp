// Вид 1
//void Method1()
//{
 //   Console.WriteLine("Author Manay");
//}
// как вызывать метод1:
//Method1();

// Вид 2
//void Method2(string msg)
//{
 //   Console.WriteLine(msg);
//
//как вызвать метод2:
//Method2(msg: "Message's text");

//void Method2_1(string msg, int count)
//
 //   int i = 0;
  //  while (i < count)
  //  {
   //     Console.WriteLine(msg);
   //     i++;
  //  }
// }
//Method2_1("Text", 4);
//Method2_1(msg: "Text", count: 4);
//Method2_1(count: 4, msg: "New text");

// Вид 3

//int Method3()
//{
 //   return DateTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);

// Вид 4
//string Method4(int count, string text)
//{
 //   int i = 0;
 //   string result = String.Empty;

 //   while (i < count)
 //   {
  //      result = result + text;
 //       i++;
  //  }
 //   return result;
// }
//string res = Method4(10, "asdf");
//Console.WriteLine(res);

//string Method4(int count, string text)
//{
  //  string result = String.Empty;
  //  for(int i = 0; i < count; i++)
  //  {
  //      result = result + text;
  //  }
  //  return result;
// }
//string res = Method4(10, "z");
//Console.WriteLine(res);

// ТАБЛИЦА УМНОЖЕНИЯ

//    for(int i = 2; i <= 10; i++)
//    {
//        for(int j = 0; j <= 10; j++)
//        {
//            Console.WriteLine($"{i} x {j} = {i * j}");
 //       }
//        Console.WriteLine();
//    }


//===========РАБОТА С ТЕКСТОМ
// Дан текстю В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К", 
// а болльшие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r (считаем с нуля)

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenghth = text.Length;
    for(int i = 0; i < lenghth; i++)
    {
        if(text[i] == oldValue) result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();