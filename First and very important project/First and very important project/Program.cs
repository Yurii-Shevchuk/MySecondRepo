// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World, my name is Yurii! What's yours?");
string strangerName = "";
while(strangerName == null || strangerName == String.Empty)
{
    strangerName = Console.ReadLine();
}

Console.WriteLine($"Nice to meet you, {strangerName}, have a nice day!");
Console.ReadLine();
