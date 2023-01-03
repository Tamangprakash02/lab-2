string[] names = { "Prakash", "Naruto", "David Bechkam", "Michael jackson" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David Bechkam") names[i] = "Saint Cazola";

foreach (var name in names) Console.WriteLine(name);