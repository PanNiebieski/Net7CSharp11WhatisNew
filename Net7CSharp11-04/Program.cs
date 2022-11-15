Console.WriteLine();

public class Klaska
{
    [Metadata(nameof(Test), nameof(param))]
    public void Test(string param)
    {
        [Metadata(nameof(LocalFunction), nameof(paramt))]
        void LocalFunction<T>(T paramt)
        {
        }

        var lambdaExpression =
            ([Metadata("lambdaExpression",nameof(cos))]
                double cos)
            => Math.Cos(cos);
    }
}


public class MetadataAttribute : Attribute
{
    public MetadataAttribute(string name, string param1)
    {

    }

    public MetadataAttribute(string name)
    {

    }
}
