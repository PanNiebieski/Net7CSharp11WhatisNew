public class CustomOldAttribute : Attribute
{
    public Type CType { get; }

    public object OldValue { get; set; }

    public CustomOldAttribute(Type type)
    {
        CType = type;
        OldValue = Activator.CreateInstance(CType);
    }

}

