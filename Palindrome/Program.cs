
var sanitizedInput = (Console.ReadLine() ?? string.Empty).Where(char.IsLetter).ToArray();
var len = sanitizedInput.Length;
var pali = true;
for (var i = 0; i < len / 2; i++)
    if (sanitizedInput[i] != sanitizedInput[len-i-1])
        pali = false;
        
Console.WriteLine(pali ? "YES":"NO");