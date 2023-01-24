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

string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
}
string res = Method4(10, "z");
Console.WriteLine(res);