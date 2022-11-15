
using System.Diagnostics.CodeAnalysis;

var game = new Game()
{
    Name = "Dune II"
};

//game.Name = "Franko";


public class Game
{
    public string Name { get; init; }

    //public required int Year { get; init; }
}


public class Person
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }

    [SetsRequiredMembers]
    public Person(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public Person() { }
}

public class Person1
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
}