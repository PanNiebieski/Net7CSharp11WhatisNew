
using System.Collections.Generic;

List<int> list = new List<int>()
{ 10, 2, 2, 33, 56, 878 };

var oldsorted = list.OrderBy(x => x);
var newsorted = list.Order();
var newsortedAgain = list.OrderDescending();

foreach (var item in oldsorted)
{
    Console.WriteLine(item);
}

Console.WriteLine("=============");

foreach (var item in newsorted)
{
    Console.WriteLine(item);
}

Console.WriteLine("=============");

foreach (var item in newsortedAgain)
{
    Console.WriteLine(item);
}

Console.WriteLine("=============");

List<Game> games = new List<Game>();
games.Add(new Game() { Name = "Persona 5 PC", Year = 2022 });
games.Add(new Game() { Name = "Settlers", Year = 1991 });


var oldsortedGame = games.OrderBy(x => x.Year);
var newsortedGame = games.Order();


foreach (var item in oldsortedGame)
{
    Console.WriteLine(item.Name);
}

//foreach (var item in newsortedGame)
//{
//    Console.WriteLine(item);
//}





public class Game
{
    public string Name { get; set; }

    public int Year { get; set; }
}









//public class Game : IComparable<Game>
//{
//    public string Name { get; set; }

//    public int Year { get; set; }

//    public override bool Equals(object obj)
//    {
//        if (ReferenceEquals(this, obj))
//        {
//            return true;
//        }

//        if (ReferenceEquals(obj, null))
//        {
//            return false;
//        }

//        throw new NotImplementedException();
//    }

//    public override int GetHashCode()
//    {
//        throw new NotImplementedException();
//    }

//    public static bool operator ==(Game left, Game right)
//    {
//        if (ReferenceEquals(left, null))
//        {
//            return ReferenceEquals(right, null);
//        }

//        return left.Equals(right);
//    }

//    public static bool operator !=(Game left, Game right)
//    {
//        return !(left == right);
//    }

//    public static bool operator <(Game left, Game right)
//    {
//        return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;
//    }

//    public static bool operator <=(Game left, Game right)
//    {
//        return ReferenceEquals(left, null) || left.CompareTo(right) <= 0;
//    }

//    public static bool operator >(Game left, Game right)
//    {
//        return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
//    }

//    public static bool operator >=(Game left, Game right)
//    {
//        return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;
//    }
//}







