using NetExtensionMethodsApp;

string s = "Hello world, hello people";
Console.WriteLine(s.CountChar('l'));

Employee employee = new Employee();
employee.Name = "Bob";
employee.Phone = "7 (890) 999-03-87";

var anonimUser = new { FullName = "Joe", BirhtDate = new DateTime(1998, 5, 17) };
Console.WriteLine(anonimUser.GetType());

var tuple = ("Hello", 35);
Console.WriteLine(tuple.Item1);
Console.WriteLine(tuple.Item2);
Console.WriteLine(tuple.GetType());

int a = 10;
int b = 20;
Console.WriteLine($"{a} {b}");
(a, b) = (b, a);
Console.WriteLine($"{a} {b}");

PrintEmployee(tuple);

void PrintEmployee((string name, int age) employe)
{
    Console.WriteLine($"{employe.name} {employe.age}");
}

static class StringExtension
{
    public static int CountChar(this string str, char symbol)
    {
        int count = 0;
        for(int i = 0; i < str.Length; i++)
            if (str[i] == symbol)
                count++;
        return count;
    }
}

