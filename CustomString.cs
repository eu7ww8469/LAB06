using System.Text;

namespace LAB06;

public class CustomString
{
private string _value;
public string Value
{
    get => _value;
    set
    {
        if (value == null)
            throw new ArgumentNullException(nameof(value), "Строка не может быть null");
        _value = value;
    }
}


public CustomString(string value)
{
    if (value == null)
        throw new ArgumentNullException(nameof(value), "Строка не может быть null");
    _value = value;
}


private int CustomStringLength()
{
    int count = 0;
    foreach (char c in _value)
    {
        count++;
    }
    return count;
}


public static CustomString operator +(CustomString a, CustomString b)
{
    if (a == null || b == null)
        throw new ArgumentNullException(a == null ? nameof(a) : nameof(b));
    return new CustomString(a._value + b._value);
}


public static CustomString operator *(CustomString s, int n)
{
    if (s == null)
        throw new ArgumentNullException(nameof(s));
    if (n < 0)
        throw new ArgumentException("Число повторений не может быть отрицательным", nameof(n));

    var sb = new StringBuilder();
    for (int i = 0; i < n; i++)
    {
        sb.Append(s._value);
    }
    return new CustomString(sb.ToString());
}


public static bool operator ==(CustomString? a, CustomString? b)
{
    if (ReferenceEquals(a, b)) return true;
    if (a is null || b is null) return false;
    return a.CustomStringLength() == b.CustomStringLength();
}

public static bool operator !=(CustomString? a, CustomString? b)
{
    return !(a == b);
}


public override bool Equals(object? obj)
{
    return obj is CustomString other && this == other;
}

public override int GetHashCode()
{
    return CustomStringLength();
}


public override string ToString()
{
    return $"CustomString: {_value}, {CustomStringLength()}";
}
}