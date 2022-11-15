int[] collection = { 1, 5 };

Factorial(collection);

var res = collection switch
{
    [1, 2] => "A",
    [2, 5] => "B",
    [1, _] => "C",
    [..] => "D",
    //[var a, .. _, var z] => $"Many found: from {a} to {z}",
};

Console.WriteLine(res);



string[] gameEndings = { "good", "bad" };

Console.WriteLine(gameEndings is ["good", "bad"]);
Console.WriteLine(gameEndings is ["good"]);
Console.WriteLine(gameEndings is ["good", "good+"]);
Console.WriteLine(gameEndings is ["good", "bad", "bad+"]);

Console.WriteLine(gameEndings
    is ["good" or "good+", "bad" or "bad+"]);

Console.WriteLine("=====");

int[] numbers = { 1, 2, 3 };

Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]);

if (numbers is [var first, .. var rest])
{
    Console.WriteLine(first);
}

var emptyArray = Array.Empty<string>();
var nameArray1 = new[] { "Adam" };
var nameArray2 = new[] { "Adam", "Walenciuk" };
var nameArray3 = new[] { "Adam", "Edward", "Walenciuk" };

Console.WriteLine(GiveMeText(emptyArray));
Console.WriteLine(GiveMeText(nameArray1));
Console.WriteLine(GiveMeText(nameArray2));
Console.WriteLine(GiveMeText(nameArray3));

string GiveMeText(string[] array)
{
    var text = array switch
    {
        [] => "Words was empty colletion",
        [var justname] => $"His name is: {justname}",
        [var name, var surname] => $"His full name is: {name} {surname}",
        [var n1, var n2, var s] => $"Name: {n1}, SecondName {n2}, Surname {s}"
    };
    return text;
}

int Factorial(int[] values)
{
    return values switch
    {
        [] => 1,
        [.. int[] numbers, int number]
                    => number * Factorial(numbers)
    };
}