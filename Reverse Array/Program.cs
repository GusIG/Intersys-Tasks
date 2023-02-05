
if (!int.TryParse(Console.ReadLine(),out var n))
    Console.WriteLine("Warning: could not parse n (expected size of array) from input");
var arr = (Console.ReadLine() ?? string.Empty).Split(" ");
if (arr.Length!=n)
{
    Console.WriteLine("Warning: inputed array length did not match previously declared size!");
    Console.WriteLine("Expected: "+n+", got: "+arr.Length);
}
Console.WriteLine(string.Join(' ', arr.Reverse()));
