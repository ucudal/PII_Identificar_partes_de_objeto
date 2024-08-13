using System;

namespace Ucu.Poo.Persons;

public class Person
{
    private string name;
    public string Name
    {
        get { return name; } set { name = value; }
    }

    private string id;
    public string Id
    {
        get { return id; } set { id = value; }
    }

    public Person(string name, string id)
    {
        this.Name = name;
        this.Id = id;
    }

    public void IntroduceYourself()
    {
        Console.WriteLine(
            $"Soy {this.Name} y mi cédula es {this.Id}");
    }
}

class Program 
{ 
    static void Main(string[] args) 
    { 
        Person john = new Person("John Doe", "1.234.567-8"); 
        Person jane = new Person("Jane Doe", "8.765.432-1"); 
        john.IntroduceYourself(); 
        jane.IntroduceYourself(); 
    } 
}
