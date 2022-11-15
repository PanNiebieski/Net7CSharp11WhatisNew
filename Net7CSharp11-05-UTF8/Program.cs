using System.Text;

string utf16 = "In this code I am UTF-16";


//string s1 = "hello"u8;
//var s2 = "hello"u8;
//byte[] s4 = "hello"u8;            
//byte[] s5 = "hello"u8.ToArray();



//Wait for Utf8String type
ReadOnlySpan<byte> utf8 = "In this code I am UTF-8"u8;



ReadOnlySpan<byte> u16C = Encoding.Unicode.GetBytes("C");
ReadOnlySpan<byte> u8C = "C"u8;

Console.WriteLine(u16C.Length);
Console.WriteLine(u8C.Length);

Console.WriteLine(u16C.ShowValues());
Console.WriteLine(u8C.ShowValues());


public static class MyExtensionMethods
{
    public static string ShowValues(this byte[] value)
    {
        StringBuilder sb = new StringBuilder();
        foreach (byte b in value)
        {
            sb.Append(b).Append(" ");
        }
        return sb.ToString();
    }

    public static string ShowValues(this ReadOnlySpan<byte> value)
    {
        StringBuilder sb = new StringBuilder();
        foreach (byte b in value)
        {
            sb.Append(b).Append(" ");
        }
        return sb.ToString();
    }
}

