void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

void Method2(string msg, int count)
{
int i = 0;
while (i < count)
{
    Console.WriteLine(msg);
    i++;
}
}
Method2("Текст1", 2);
Method2(count:2, msg:"Текст2");

int Method3(){
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

string Method4(int count, string text)
{
int i = 0;
string result = String.Empty;
while (i < count)
{
    result += text;
    i++;
}
return result;
}
string res = Method4(10 ,"Ха-");
Console.WriteLine(res);