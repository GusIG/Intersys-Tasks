using System.Numerics;

var inpts = new List<uint>();
var line = Console.ReadLine();
while (!string.IsNullOrEmpty(line))
{
    inpts.Add(uint.Parse(line ?? "0"));
    line = Console.ReadLine();
}

var biggestNum = inpts.Max();
var mSignificantBit = 32 - BitOperations.LeadingZeroCount(biggestNum);
var result = new uint[mSignificantBit];
const uint factor = 0x1;
for (var i = 0; i < mSignificantBit; i++)
{
    result[i] = factor << i;
}

Console.WriteLine(string.Join(' ', result));