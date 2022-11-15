//Pattern match Span<char> or ReadOnlySpan<char> on a constant string


ReadOnlySpan<char> text = "Persona 5";

if (text is "Persona 5")
{
    Console.WriteLine("This is Persona 5");
}

if (text is ['P', 'e', ..])
{
    Console.WriteLine("This is Pe...");
}
