

Calculations c = new(0, 1000, 8000, 9000);

Console.WriteLine(c.Calculate());

public class Calculations
{
    private static List<int> numbers1;

    private static List<int> numbers2;

    public Calculations(int from1, int to1,
        int from2, int to2)
    {
        numbers1 =
            Enumerable.Range(from1, to1).ToList();
        numbers2 =
            Enumerable.Range(from2, to2).ToList();
    }

    static bool IsPowerOfTwo(int number)
    {
        return (number & (number - 1)) == 0;
    }

    static bool IsDivisibleBy2(int number)
    {
        return number % 2 == 0;
    }

    //Run Time Slower before C# 11
    public int Calculate()
    {
        var sum1 = numbers1.
            Where(x => IsPowerOfTwo(x)).Sum();

        var sum2 = numbers2.
            Where(x => IsDivisibleBy2(x)).Sum();

        return sum1 + sum2;
    }

    public int SumMethodGroup()
    {
        var sum1 = numbers1.
            Where(IsPowerOfTwo).Sum();

        var sum2 = numbers2.
            Where(IsDivisibleBy2).Sum();

        return sum1 + sum2;
    }


}