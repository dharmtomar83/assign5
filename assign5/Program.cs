
using System;

public partial class assign5
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

using System;

public partial class assign5
{
    public void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
}

class Program
{
    static void Main()
    {
        
        assign5 person = new assign5
        {
            FirstName = "John",
            LastName = "Doe"
        };

        person.PrintFullName();
    }
}