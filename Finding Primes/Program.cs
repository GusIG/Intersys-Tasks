if (!int.TryParse(Console.ReadLine(), out var n))
    Console.WriteLine("Warning: could not parse n (expected size of array) from input");
var inputs = new (int, int)[n];
for (var i = 0; i < n; i++)
{
    var line = Console.ReadLine()!.Split(" ");
    inputs[i] = (int.Parse(line[0]), int.Parse(line[1]));
}

for (var i = 0; i < n; i++)
{
    Console.WriteLine(CountPrimes(inputs[i].Item1, inputs[i].Item2));
}


static int CountPrimes(int lowerBound, int upperBound)
{
    var primes = new List<int>();
    if (lowerBound < 2 && upperBound >= 2)
        primes.Add(2);
    if (lowerBound % 2 == 0) lowerBound++;
    if (lowerBound == 1) lowerBound = 3;
    for (var i = lowerBound; i <= upperBound; i += 2)
    {
        var isPrime = true;
        for (var j = 3; j <= Math.Sqrt(i); j += 2)
        {
            if (i % j == 0)
                isPrime = false;
        }

        if (isPrime) primes.Add(i);
    }

    return primes.Count;
}