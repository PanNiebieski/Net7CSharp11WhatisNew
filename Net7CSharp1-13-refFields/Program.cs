using Microsoft.Extensions.Logging;
using System.Buffers;
using System.Text;
using System.Text.Json;


//This functionality is tremendously useful when dealing with ref structs,
//since you often need to stackalloc a buffer that is passed to the method of a ref struct.
//https://stackoverflow.com/questions/73375011/what-is-the-purpose-of-the-scoped-keyword

var holder = new Holder(6);
Span<char> chars =
    stackalloc char[3] { 'C', 'e', 'z' };

holder.Append(chars);
holder.Append(chars);

Console.WriteLine(holder.ToString());


static void GetMoreBytesFromStream(MemoryStream stream,
    scoped ref byte[] buffer,
    ref Utf8JsonReader reader, ILogger log)
{
    int bytesRead;
    // throw new Exception();
    if (reader.BytesConsumed < buffer.Length)
    {
        log.LogTrace("Recreating buffer {Consumed} < {Length}",
            reader.BytesConsumed, buffer.Length);

        ReadOnlySpan<byte> leftover = buffer.AsSpan((int)reader.BytesConsumed);

        if (leftover.Length == buffer.Length)
        {
            Array.Resize(ref buffer, buffer.Length * 2);
            log.LogTrace("Increased buffer size to {Size}", buffer.Length);
        }

        leftover.CopyTo(buffer);
        bytesRead = stream.Read(buffer.AsSpan(leftover.Length));
    }
    else
    {
        bytesRead = stream.Read(buffer);
    }

    log.LogTrace("New String in buffer is: {Buffer}",
        Encoding.UTF8.GetString(buffer));

    reader = new Utf8JsonReader(buffer, isFinalBlock: bytesRead == 0,
        reader.CurrentState);
}

public ref struct Holder
{
    private readonly Span<char> _chars;
    private int _pos;

    public Holder(int size)
    {
        _chars = ArrayPool<char>.Shared.Rent(size);
        _pos = 0;
    }

    //scoped allows us to now tell the compiler
    //that the method will creates a sense of "scope"
    //for the lifetime of the buffer
    public void Append(scoped ReadOnlySpan<char> VALUE)
    {
        if (VALUE.TryCopyTo(_chars.Slice(_pos)))
        {
            _pos += VALUE.Length;
        }
    }

    public override string ToString()
    {
        return new string(Text);
    }

    private ReadOnlySpan<char> Text => _chars[.._pos];
}