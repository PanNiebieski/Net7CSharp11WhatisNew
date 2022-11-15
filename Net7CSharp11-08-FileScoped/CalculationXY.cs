file class HiddentParameterX : IHiddentParameter
{
    private int _x;

    public HiddentParameterX(int a)
    {
        _x = a;
    }

    public int Value => _x + 5;
}

file class HiddentParameterY : IHiddentParameter
{
    private int _y;

    public HiddentParameterY(int a)
    {
        _y = a;
    }

    public int Value => _y * -1;
}

file interface IHiddentParameter
{
    public int Value { get; }
}

public class CalculationXY
{
    //readonly List<IHiddentParameter> parameters;

    public CalculationXY()
    {
        List<IHiddentParameter> parameters;

        parameters = new List<IHiddentParameter>();
        parameters.Add(new HiddentParameterX(10));
        parameters.Add(new HiddentParameterY(1));

        foreach (var item in parameters)
        {
            Result += item.Value;
        }
    }

    public int Result { get; }
}

