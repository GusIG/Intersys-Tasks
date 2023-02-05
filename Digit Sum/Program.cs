if (!int.TryParse(Console.ReadLine(), out var n))
    Console.WriteLine("Warning: could not parse n (expected size of array) from input");
var arr = (Console.ReadLine() ?? string.Empty).Split(" ");
if (arr.Length != n)
{
    Console.WriteLine("Warning: inputed array length did not match previously declared size!");
    Console.WriteLine("Expected: " + n + ", got: " + arr.Length);
}

var sums = arr.Select(s => s.Sum(c => int.Parse(c.ToString()))).ToList();
var index = sums.IndexOf(sums.Max());

Console.WriteLine(index);