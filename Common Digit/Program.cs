
if (!int.TryParse(Console.ReadLine(),out var n))
    Console.WriteLine("Warning: could not parse n (expected size of array) from input");
var input=Console.ReadLine() ?? string.Empty;
var arrLen = input.Split(" ").Length;
if (arrLen!=n)
{
    Console.WriteLine("Warning: inputed array length did not match previously declared size!");
    Console.WriteLine("Expected: "+n+", got: "+arrLen);
}

var result = input.GroupBy(c => c).Select(grp =>new
{
    val=grp.Key,
    count=grp.Count()
        
}).OrderByDescending(r=>r.count).ThenByDescending(r=>r.val);

Console.WriteLine(int.Parse(result.First().val.ToString()));