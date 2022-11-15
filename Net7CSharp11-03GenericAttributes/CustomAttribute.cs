
class CustomAttribute<T> : Attribute
        where T : class, new()
{
    public Type CType { get; }

    public T Value { get; set; }

    public CustomAttribute()
    {
        CType = typeof(T);
        Value = new T();
    }

}


