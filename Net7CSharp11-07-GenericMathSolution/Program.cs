
using System.Numerics;

var numbers1 = new[] { 1.5, 0.5, 0.3 };
var numbers2 = new[] { 9, 2, 3 };

var r1_1 = MultiplyNumbers(numbers1);
var r1_2 = AddNumbers(numbers1);

var r2_1 = MultiplyNumbers(numbers2);
var r2_2 = AddNumbers(numbers2);

Console.WriteLine(r1_1);
Console.WriteLine(r1_2);
Console.WriteLine(r2_1);
Console.WriteLine(r2_2);


T MultiplyNumbers<T>(T[] values) where T : INumber<T>
{
    T result = T.One;

    foreach (var item in values)
    {
        result *= item;

    }

    return result;
}

T AddNumbers<T>(T[] values) where T : INumber<T>
{
    T result = T.Zero;

    foreach (var item in values)
    {
        result += item;

    }

    return result;
}

//T ShowMax<T>() where T : INumber<T>
//{
//    return T.Max(T.Zero,T.);
//}

