
int[] arr1, arr2;
try
{
    arr1 = (Console.ReadLine() ?? string.Empty).Split(" ").Select(int.Parse).ToArray();
    arr2 = (Console.ReadLine() ?? string.Empty).Split(" ").Select(int.Parse).ToArray();
}
catch (FormatException e)
{
    Console.WriteLine("Input could not be parsed into number! Aborting");
    throw e;
}

if (arr1.Length != arr2.Length)
{
    Console.WriteLine("First and seccond inputs have different length! Aborting");
    Environment.Exit(-1);
}

if (arr1.Length != 11)
{
    Console.WriteLine("Warning: input array differes in size with expected size of: 11");
}

var occurrences = new Dictionary<int, int>();

for (var i = 0; i < arr1.Length; i++)
{
    var num1 = arr1[i];
    var num2 = arr2[i];
    occurrences.TryAdd(num1, 0);
    occurrences.TryAdd(num2, 0);
    occurrences[num1] += 1;
    occurrences[num2] -= 1;
}

Console.WriteLine(occurrences.Values.All(v => v == 0) ?"YES":"NO");