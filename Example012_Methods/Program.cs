// Вид 1
void Method1()
{
    Console.WriteLine("Author Manay");
}
// как вызывать метод1:
//Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//как вызвать метод2:
//Method2(msg: "Message's text");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method2_1("Text", 4);
//Method2_1(msg: "Text", count: 4);
Method2_1(count: 4, msg: "New text");
