using LAB06;

CustomString str1 = new CustomString("Hello");
CustomString str2 = new CustomString("World");
CustomString str3 = new CustomString("Hi");

Console.WriteLine(str1);
Console.WriteLine(str2);
Console.WriteLine(str3);

CustomString str4 = str1 + str2;
Console.WriteLine(str4);

CustomString str5 = str1 * 3;
Console.WriteLine(str5);

CustomString empty = str1 * 0;
Console.WriteLine($"str1 * 0 -> {empty}");

Console.WriteLine($"str1 == str2 -> {str1 == str2}");
Console.WriteLine($"str1 != str3 -> {str1 != str3}");
Console.WriteLine($"str1 == str3 -> {str1 == str3}");

Console.WriteLine($"str3.Value = {str3.Value}");
str3.Value = "Privet";
Console.WriteLine($"После изменения: {str3}");

try
{
    str3.Value = null!;
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"Ошибка свойства: {ex.Message}");
}

try
{
    CustomString bad = new CustomString(null!);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"Ошибка конструктора: {ex.Message}");
}

try
{
    CustomString negative = str1 * -2;
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка оператора *: {ex.Message}");
}