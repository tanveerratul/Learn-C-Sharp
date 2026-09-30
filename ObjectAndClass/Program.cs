using System.Security.Cryptography;

class Person
{
    public string name = "";
    public int age;
}

class Tutorials
{
    public static void Main(string[]args)
    {
        Person p1 = new Person();
        p1.name = "Tanveer Ratul";
        p1.age = 25;

        Person p2 = new Person();
        p2. name = "Ismail Sheikh";
        p2.age = 26;

        Person p3 = new Person();
        p3.name = "Humayra Maya";
        p3.age = 22;

        Console.Write($"Person 1 \n {p1.name} \n {p1.age} \n\nPerson 2 \n {p2.name} \n {p2.age} \n\nPerson 3 \n{p3.name} \n{p3.age}");
    }
}