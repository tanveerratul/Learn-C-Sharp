using System;

class Person
{
    public string name;
    public int age;

    public void DisplayInformation()
    {
        Console.Write($"Person 1 \n {name} \n {age} \n\n");
    }
}
class Methods
{
    public static void Main (string[]args)
    {
        Person p1 = new Person();
        p1.name = "Tanveer Ratul";
        p1.age = 25;
        p1.DisplayInformation();

        Person p2 = new Person();
        p2.name = "Istiaq Alam";
        p2.age = 25;
        p2.DisplayInformation();
    }
}